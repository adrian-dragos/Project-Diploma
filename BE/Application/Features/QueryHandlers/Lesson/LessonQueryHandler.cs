using Application.DTOs;
using Application.DTOs.Lesson;
using Application.DTOs.Pagination;
using Application.Features.Queries.Lesson;
using Application.Interfaces;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers
{
    internal sealed class LessonQueryHandler :
        IRequestHandler<GetLessonsListQuery, PagedResultDto<GetLessonsDto>>,
        IRequestHandler<GetInstructorLessonsListQuery, PagedResultDto<GetInstructorLessonsListDto>>,
        IRequestHandler<GetAvailableLessonsListQuery, IEnumerable<GetAvailableLessonsDto>>
    {
        private readonly IRepository<Lesson> _lessonRepository;

        public LessonQueryHandler(IRepository<Lesson> lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }
        public async Task<PagedResultDto<GetLessonsDto>> Handle(GetLessonsListQuery request, CancellationToken cancellationToken)
        {
            var lessonQuery = _lessonRepository
                .Read()
                .AsNoTracking();

            if (request.StudentIds?.Any() ?? false)
            {
                lessonQuery = lessonQuery.Where(l => l.StudentId != null && request.StudentIds.Contains((int)l.StudentId));
            }

            if (request.InstructorIds?.Any() ?? false)
            {
                lessonQuery = lessonQuery.Where(l => request.InstructorIds.Contains(l.InstructorId));
            }

            if (request.StartDate != null) {
                var nonNullableStartDate = request.StartDate.GetValueOrDefault().AddDays(1);
                lessonQuery = lessonQuery.Where(l => l.StartTime.Year >= nonNullableStartDate.Year &&
                                                        l.StartTime.Month >= nonNullableStartDate.Month &&
                                                        l.StartTime.Day >= nonNullableStartDate.Day);
            }

            if (request.EndDate != null)
            {
                var nonNullableEndDate = request.EndDate.GetValueOrDefault().AddDays(1);
                lessonQuery = lessonQuery.Where(l => l.StartTime.Year <= nonNullableEndDate.Year &&
                                                       l.StartTime.Month <= nonNullableEndDate.Month &&
                                                       l.StartTime.Day <= nonNullableEndDate.Day);
            }

            if (request.LessonStatuses?.Any() ?? false)
            {
                lessonQuery = lessonQuery.Where(l => request.LessonStatuses.Contains(l.Status));
            } 
            else
            {
                lessonQuery = lessonQuery.Where(l => l.Status == LessonStatus.Unbooked ||
                                                     l.Status == LessonStatus.BookedPaid ||
                                                     l.Status == LessonStatus.Completed ||
                                                     l.Status == LessonStatus.Canceled);
            }

            var lessonFilteredQuery = lessonQuery.Select(l => new GetLessonsDto
            {
                Id = l.Id,
                StartTime = l.StartTime,
                EndTime = l.StartTime.AddMinutes(90),
                InstructorName = $"{l.Instructor.Identity.FirstName} {l.Instructor.Identity.LastName}",
                Location = l.Instructor.Location,
                Status = l.Status
            });

            if (request.Page.Ascending)
            {
                lessonFilteredQuery = lessonFilteredQuery.OrderBy(l => l.StartTime);
            } else
            {
                lessonFilteredQuery = lessonFilteredQuery.OrderByDescending(l => l.StartTime);
            }


            var pagedResult = new PagedResultDto<GetLessonsDto>
            {
                Page = request.Page.Page,
                PageSize = request.Page.Page,
                TotalCount = await lessonQuery.CountAsync(cancellationToken),
                Items = await lessonFilteredQuery
                    .Skip((request.Page.Page - 1) * request.Page.PageSize)
                    .Take(request.Page.PageSize)
                    .ToListAsync(cancellationToken)
            };

            await MarkAsComplete(cancellationToken);
            return pagedResult;
        }

        public async Task<PagedResultDto<GetInstructorLessonsListDto>> Handle(GetInstructorLessonsListQuery request, CancellationToken cancellationToken)
        {
            var lessonQuery = _lessonRepository
                .Read()
                .AsNoTracking()
                .Where(l => l.InstructorId == request.InstructorId)
                .Select(l => new GetInstructorLessonsListDto
                {
                    Id = l.Id,
                    StartTime = l.StartTime,
                    EndTime = l.StartTime.AddMinutes(90),
                    StudentName = $"{l.Student.Identity.FirstName} {l.Student.Identity.LastName}",
                    Location = l.Instructor.Location,
                    Status = l.Status
                });


            await MarkAsComplete(cancellationToken);

            if (request.PageDto.Ascending)
            {
                lessonQuery = lessonQuery.OrderBy(l => l.StartTime);
            } 
            else
            {
                lessonQuery = lessonQuery.OrderByDescending(l => l.StartTime);
            }

            var pagedResult = new PagedResultDto<GetInstructorLessonsListDto>
            {
                Page = request.PageDto.Page,
                PageSize = request.PageDto.Page,
                TotalCount = await lessonQuery.CountAsync(cancellationToken),
                Items = await lessonQuery
                    .Skip((request.PageDto.Page - 1) * request.PageDto.PageSize)
                    .Take(request.PageDto.PageSize)
                    .ToListAsync(cancellationToken)
            };

            return pagedResult;
        }

        public async Task<IEnumerable<GetAvailableLessonsDto>> Handle(GetAvailableLessonsListQuery request, CancellationToken cancellationToken)
        {
            var startDate = GetDate(request.StartDate);
            var endDate = GetDate(request.EndDate);

            var lessonsQuery = _lessonRepository
                .Read()
                .AsNoTracking()
                .Include(l => l.Instructor.Identity)
                .Include(l => l.Car.CarModel)
                .Include(l => l.Student.Identity)
                .Where(l => l.StartTime >= startDate && l.StartTime <= endDate &&
                                l.Car.CarModel.CarGear == request.CarGear && (
                                l.Status == LessonStatus.Unbooked ||
                                l.Status == LessonStatus.BookedNotPaid));


            if (request.InstructorId is not null)
            {
                lessonsQuery = lessonsQuery.Where(l => l.InstructorId == request.InstructorId);
            }

            var lessons = await lessonsQuery.ToListAsync(cancellationToken);
            if (request.CarModels?.Any() ?? false) 
            {
                lessons = lessons
                    .Where(l => request.CarModels.Any(c => c.Manufacturer == l.Car.CarModel.Manufacturer &&
                             c.Model == l.Car.CarModel.Model
                        ))
                    .ToList();
            }

            var now = DateTimeOffset.Now;
            var result = lessons
                .GroupBy(l => new { l.StartTime.Year, l.StartTime.Month, l.StartTime.Day })
                .Select(l => new GetAvailableLessonsDto
                {
                    Date = new DateTimeOffset(new DateTime(l.Key.Year, l.Key.Month, l.Key.Day)),
                    LessonsDetails = l.Select(l => new GetAvailableLessonDetailsDto
                    {
                        Id = l.Id,
                        StudentName = l.StudentId == null ? null : l.Student.Identity.FirstName +  " " + l.Student.Identity.LastName,
                        StartTime = l.StartTime,
                        EndTime = l.StartTime.AddHours(1).AddMinutes(30),
                        InstructorName = l.Instructor.Identity.FirstName + " " + l.Instructor.Identity.LastName,
                        CarManufacturer = l.Car.CarModel.Manufacturer,
                        CarModel = l.Car.CarModel.Model,
                        CarRegistrationNumber = l.Car.RegistrationNumber,
                        CarGear = l.Car.CarModel.CarGear,
                        Status = l.Status,
                        InstructorPhoneNumber = l.Instructor.Identity.PhoneNumber,
                        Location = l.Instructor.Location,
                        CanBook = l.StartTime.AddMinutes(-90) > now
                    })
                    .OrderBy(l => l.StartTime)

                })
                .ToList();

            result = AddMissingDays(result, startDate, endDate);
            return result.OrderBy(l => l.Date);
        }

        private List<GetAvailableLessonsDto> AddMissingDays(List<GetAvailableLessonsDto> lessons, DateTimeOffset startDate, DateTimeOffset endDate)
        {
            foreach (int dayOffset in Enumerable.Range(0, (endDate - startDate).Days))
            {
                var date = startDate.AddDays(dayOffset);
                if (!lessons.Any(l => GetDate(l.Date) == date))
                {
                    lessons.Add(new GetAvailableLessonsDto
                    {
                        Date = date
                    });
                }
            }
            return lessons;
        }

        private async Task<Unit> MarkAsComplete(CancellationToken cancellationToken)
        {
            var now = DateTimeOffset.Now;
            var lessons = await _lessonRepository
               .Read()
               .Where(l => l.StartTime <= now && l.StudentId != null)
               .ToListAsync(cancellationToken);

            foreach (var lesson in lessons)
            {
                lesson.Status = LessonStatus.Completed;
            }

            _lessonRepository.UpdateRange(lessons);

            return Unit.Value;
        }

        private DateTimeOffset GetDate(DateTimeOffset date)
        {
            return new DateTimeOffset(date.Date, TimeSpan.Zero);
        }
    }
}
