using Application.DTOs;
using Application.DTOs.Lesson;
using Application.Features.Queries.Lesson;
using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers
{
    internal sealed class LessonQueryHandler :
        IRequestHandler<GetStudentLessonsListQuery, IEnumerable<GetStudentLessonsListDto>>,
        IRequestHandler<GetInstructorLessonsListQuery, IEnumerable<GetInstructorLessonsListDto>>,
        IRequestHandler<GetAvailableLessonsListQuery, IEnumerable<GetAvailableLessonsDto>>
    {
        private readonly IRepository<Lesson> _lessonRepository;

        public LessonQueryHandler(IRepository<Lesson> lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        public async Task<IEnumerable<GetStudentLessonsListDto>> Handle(GetStudentLessonsListQuery request, CancellationToken cancellationToken)
        {
            return await _lessonRepository
                .Read()
                .AsNoTracking()
                .Where(l => l.StudentId == request.StudentId)
                .Select(l => new GetStudentLessonsListDto
                {
                    Id = l.Id,
                    LessonDate = l.StartTime,
                    InstructorName = $"{l.Instructor.Identity.FirstName} {l.Instructor.Identity.LastName}",
                    Location = "No Location For Now"
                })
                .ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<GetInstructorLessonsListDto>> Handle(GetInstructorLessonsListQuery request, CancellationToken cancellationToken)
        {
            return await _lessonRepository
               .Read()
               .AsNoTracking()
               .Where(l => l.InstructorId == request.InstructorId)
               .Select(l => new GetInstructorLessonsListDto
               {
                   Id = l.Id,
                   LessonDate = l.StartTime,
                   StudentName = $"{l.Student.Identity.FirstName} {l.Student.Identity.LastName}",
                   Location = "No Location For Now"
               })
               .ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<GetAvailableLessonsDto>> Handle(GetAvailableLessonsListQuery request, CancellationToken cancellationToken)
        {
            var startDate = request.StartDate.AddDays(1);
            startDate = new DateTimeOffset(new DateTime(startDate.Year, startDate.Month, startDate.Day));
            var endDate = request.EndDate.AddDays(2);
            endDate = new DateTimeOffset(new DateTime(endDate.Year, endDate.Month, endDate.Day));

            var lessons = _lessonRepository
                .Read()
                .AsNoTracking()
                .Include(l => l.Instructor.Identity)
                .Include(l => l.Car.CarModel)
                .Where(l => l.StartTime >= startDate && l.StartTime <= endDate &&
                                l.Car.CarModel.Manufacturer == request.CarManufacturer &&
                                l.Car.CarModel.Model == request.CarModel &&
                                l.Car.CarModel.CarGear == request.CarGear)
                .AsEnumerable()
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

            foreach (int dayOffset in Enumerable.Range(0, (endDate - startDate).Days))
            {
                var date = request.StartDate.AddDays(dayOffset);
                if (!lessons.Any(l => l.Date == date))
                {
                    lessons.Add(new GetAvailableLessonsDto
                    {
                        Date = date
                    });
                }
            }
            return lessons.OrderBy(l => l.Date);
        }
    }
}
