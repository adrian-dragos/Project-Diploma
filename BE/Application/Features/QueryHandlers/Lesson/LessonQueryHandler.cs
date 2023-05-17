using Application.DTOs;
using Application.Features.Queries.Lesson;
using Application.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.QueryHandlers
{
    public sealed class LessonQueryHandler :
        IRequestHandler<GetStudentLessonsListQuery, IEnumerable<GetStudentLessonsListDto>>
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

            var lessons = await _lessonRepository
                .Read()
                .AsNoTracking()
                .Where(x => x.StudentId == request.StudentId)
                .ProjectTo<GetStudentLessonsListDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return lessons;
        }
    }
}
