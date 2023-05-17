using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapperProfiles
{
    public sealed class LessonProfile : Profile
    {
        public LessonProfile() 
        { 
            CreateMap<Lesson, GetStudentLessonsListDto>();
        }
    }
}
