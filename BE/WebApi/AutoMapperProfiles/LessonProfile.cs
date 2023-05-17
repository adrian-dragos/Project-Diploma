using Application.DTOs;
using Application.DTOs.Lesson;
using AutoMapper;
using WebApi.ViewModels.Lesson;

namespace WebApi.AutoMapperProfiles
{
    public sealed class LessonProfile : Profile
    {
        public LessonProfile()
        {
            CreateMap<GetStudentLessonsListDto, GetStudentLessonsListViewModel>();
            CreateMap<GetInstructorLessonsListDto, GetInstructorLessonsListViewModel>();
        }
    }
}
