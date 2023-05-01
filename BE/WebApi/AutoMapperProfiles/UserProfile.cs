using Application.DTOs.User;
using AutoMapper;
using WebApi.ViewModels.User;

namespace WebApi.AutoMapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, UserViewModel>().ReverseMap();
        }
    }
}
