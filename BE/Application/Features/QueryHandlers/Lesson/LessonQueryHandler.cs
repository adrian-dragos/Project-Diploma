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
        IRequestHandler<GetStudentLessonsListQuery, PagedResultDto<GetStudentLessonsListDto>>,
        IRequestHandler<GetInstructorLessonsListQuery, PagedResultDto<GetInstructorLessonsListDto>>,
        IRequestHandler<GetAvailableLessonsListQuery, IEnumerable<GetAvailableLessonsDto>>
    {
        private readonly IRepository<Lesson> _lessonRepository;

        public LessonQueryHandler(IRepository<Lesson> lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }
        public async Task<PagedResultDto<GetStudentLessonsListDto>> Handle(GetStudentLessonsListQuery request, CancellationToken cancellationToken)
        {
            var lessonQuery = _lessonRepository
                .Read()
                .AsNoTracking()
                .Where(l => l.StudentId == request.StudentId)
                .OrderByDescending(l => l.StartTime)
                .Select(l => new GetStudentLessonsListDto
                {
                    Id = l.Id,
                    StartTime = l.StartTime,
                    EndTime = l.StartTime.AddMinutes(90),
                    InstructorName = $"{l.Instructor.Identity.FirstName} {l.Instructor.Identity.LastName}",
                    Location = l.Instructor.Location,
                    Status = l.Status
                });

            var pagedResult = new PagedResultDto<GetStudentLessonsListDto>
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

        public async Task<PagedResultDto<GetInstructorLessonsListDto>> Handle(GetInstructorLessonsListQuery request, CancellationToken cancellationToken)
        {
            var lessonQuery = _lessonRepository
                .Read()
                .AsNoTracking()
                .Where(l => l.InstructorId == request.InstructorId)
                .OrderByDescending(l => l.StartTime)
                .Select(l => new GetInstructorLessonsListDto
                {
                    Id = l.Id,
                    StartTime = l.StartTime,
                    EndTime = l.StartTime.AddMinutes(90),
                    StudentName = $"{l.Student.Identity.FirstName} {l.Student.Identity.LastName}",
                    Location = l.Instructor.Location,
                    Status = l.Status
                });

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
            var startDate = request.StartDate.AddDays(1);
            startDate = new DateTimeOffset(new DateTime(startDate.Year, startDate.Month, startDate.Day));
            var endDate = request.EndDate.AddDays(2);
            endDate = new DateTimeOffset(new DateTime(endDate.Year, endDate.Month, endDate.Day));

            var lessonsQuery = _lessonRepository
                .Read()
                .AsNoTracking()
                .Include(l => l.Instructor.Identity)
                .Include(l => l.Car.CarModel)
                .Where(l => l.StartTime >= startDate && l.StartTime <= endDate &&
                                l.Car.CarModel.CarGear == request.CarGear &&
                                l.Status == LessonStatus.Unbooked);

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
            
            var result = lessons
                .GroupBy(l => new { l.StartTime.Year, l.StartTime.Month, l.StartTime.Day })
                .Select(l => new GetAvailableLessonsDto
                {
                    Date = new DateTimeOffset(new DateTime(l.Key.Year, l.Key.Month, l.Key.Day)),
                    LessonsDetails = l.Select(l => new GetAvailableLessonDetailsDto
                    {
                        Id = l.Id,
                        StartTime = l.StartTime,
                        EndTime = l.StartTime.AddHours(1).AddMinutes(30),
                        InstructorName = l.Instructor.Identity.FirstName + " " + l.Instructor.Identity.LastName,
                        CarManufacturer = l.Car.CarModel.Manufacturer,
                        CarModel = l.Car.CarModel.Model,
                        CarGear = l.Car.CarModel.CarGear
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
                if (!lessons.Any(l => l.Date == date))
                {
                    lessons.Add(new GetAvailableLessonsDto
                    {
                        Date = date
                    });
                }
            }
            return lessons;
        }
    }
}
