using Application.DTOs.Payment;
using AutoMapper;
using WebApi.ViewModels.Payment;

namespace WebApi.AutoMapperProfiles
{
    public class PaymentProfile : Profile
    {
        public PaymentProfile()
        {
            CreateMap<GetStudentPaymentDto, GetStudentPaymentViewModel>();
        }
    }
}
