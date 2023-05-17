using Application.DTOs.User;
using Application.Features.Commands.User;
using AutoMapper;
using WebApi.ViewModels.User;

namespace WebApi.AutoMapperProfiles
{
    public sealed class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, UserViewModel>();
            CreateMap<RegisterUserRequestViewModel, RegisterUserCommand>();
            CreateMap<RegisterUserDto, RegisterUserResponeViewModel>();
        }
    }
}
