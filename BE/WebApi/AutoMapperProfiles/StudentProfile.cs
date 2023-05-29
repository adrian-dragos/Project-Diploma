using Application.DTOs.Student;
using Application.Features.Commands.Student;
using AutoMapper;
using WebApi.ViewModels.Student;

namespace WebApi.AutoMapperProfiles
{
    public sealed class StudentProfile : Profile
    {
        public StudentProfile() 
        {
            CreateMap<StudentProfileDto, StudentProfileViewModel>();
            CreateMap<UpdateStudentProfileViewModel, UpdateStudentProfileCommand>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
