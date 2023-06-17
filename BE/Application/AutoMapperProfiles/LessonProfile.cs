using Application.DTOs;
using Application.DTOs.Lesson;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapperProfiles
{
    internal sealed class LessonProfile : Profile
    {
        public LessonProfile() 
        { 
            CreateMap<Lesson, GetLessonsDto>();
            CreateMap<Lesson, AddLessonResponseDto>();
        }
    }
}
