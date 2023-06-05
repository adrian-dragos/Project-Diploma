using Application.DTOs;
using Application.DTOs.Lesson;
using Application.Features.Commands.Lesson;
using Application.Features.Queries.Lesson;
using AutoMapper;
using WebApi.ViewModels.Lesson;

namespace WebApi.AutoMapperProfiles
{
    internal sealed class LessonProfile : Profile
    {
        public LessonProfile()
        {
            CreateMap<GetLessonsViewModel, GetLessonsListQuery>();
            CreateMap<GetLessonsListDto, GetStudentLessonsListViewModel>();
            CreateMap<GetInstructorLessonsListDto, GetInstructorLessonsListViewModel>();
            CreateMap<GetAvailableLessonDetailsDto, GetAvailableLessonDetailsViewModel>();
            CreateMap<GetAvailableLessonsDto, GetAvailableLessonsViewModel>();
            CreateMap<LessonFilterViewModel, GetAvailableLessonsListQuery>();
            CreateMap<BookLessonViewModel, BookLessonCommand>();
            CreateMap<UnbookLessonViewModel, UnbookLessonCommand>();
        }
    }
}
