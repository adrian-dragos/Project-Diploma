using Application.DTOs.Instructor;
using AutoMapper;
using WebApi.ViewModels.Instructor;

namespace WebApi.AutoMapperProfiles
{
    internal sealed class InstructorProfile : Profile
    {
        public InstructorProfile()
        {
            CreateMap<InstructorProfileDto, InstructorProfileViewModel>();
        }
    }
}
