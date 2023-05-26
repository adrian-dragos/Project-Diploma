using Application.DTOs.Instructor;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapperProfiles
{
    internal sealed class InstructorsProfile : Profile
    {
        public InstructorsProfile() 
        {
            CreateMap<Instructor, InstructorProfileDto>();
        }
    }
}
