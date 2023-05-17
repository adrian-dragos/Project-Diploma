using Application.DTOs;
using Application.DTOs.Lesson;
using Application.Features.Queries.Lesson;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers
{
    public sealed class LessonQueryHandler :
        IRequestHandler<GetStudentLessonsListQuery, IEnumerable<GetStudentLessonsListDto>>,
        IRequestHandler<GetInstructorLessonsListQuery, IEnumerable<GetInstructorLessonsListDto>>
    {
        private readonly IRepository<Lesson> _lessonRepository;
        private readonly IMapper _mapper;

        public LessonQueryHandler(IRepository<Lesson> lessonRepository, IMapper mapper)
        {
            _lessonRepository = lessonRepository;
            _mapper = mapper;
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
                    InstructorName = $"{l.Instructor.Identity.FirstName} {l.Instructor.Identity.FirstName}",
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
                   StudentName = $"{l.Student.Identity.FirstName} {l.Student.Identity.FirstName}",
                   Location = "No Location For Now"
               })
               .ToListAsync(cancellationToken);
        }
    }
}
