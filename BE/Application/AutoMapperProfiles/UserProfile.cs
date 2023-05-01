using Application.DTOs.User;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
