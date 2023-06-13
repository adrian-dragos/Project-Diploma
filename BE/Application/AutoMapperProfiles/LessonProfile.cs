using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapperProfiles
{
    internal sealed class LessonProfile : Profile
    {
        public LessonProfile() 
        { 
            CreateMap<Lesson, GetLessonsDto>();
        }
    }
}
