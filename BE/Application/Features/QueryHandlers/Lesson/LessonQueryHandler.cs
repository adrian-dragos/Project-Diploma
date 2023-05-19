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
        IRequestHandler<GetInstructorLessonsListQuery, IEnumerable<GetInstructorLessonsListDto>>
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
    }
}
