using Application.DTOs.Car;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapperProfiles
{
    internal sealed class CarProfile : Profile
    {
        public CarProfile() 
        {
            CreateMap<Car, CarModelDto>().ReverseMap();
        }
    }
}
