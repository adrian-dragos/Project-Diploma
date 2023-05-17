using Application.DTOs.User;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapperProfiles
{
    public sealed class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Identity, UserDto>();
            CreateMap<Identity, RegisterUserDto>();
        }
    }
}
