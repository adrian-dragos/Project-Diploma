using Application.DTOs.Student;
using AutoMapper;
using WebApi.ViewModels.Student;

namespace WebApi.AutoMapperProfiles
{
    public sealed class StudentProfile : Profile
    {
        public StudentProfile() 
        {
            CreateMap<StudentProfileDto, StudentProfileViewModel>();
        }
    }
}
