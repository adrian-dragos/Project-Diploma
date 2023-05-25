using Application.DTOs.Car;
using AutoMapper;
using WebApi.ViewModels.Car;

namespace WebApi.AutoMapperProfiles
{
    internal sealed class CarProfile : Profile
    {
        public CarProfile() 
        {
            CreateMap<InstructorCarDto, InstructorCarViewModel>();
            CreateMap<CarModelDto, CarModelViewModel>();
        }
    }
}
