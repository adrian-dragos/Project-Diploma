using Application.DTOs.Payment;
using Application.Features.Commands.Payment;
using Application.Features.Queries.Payment;
using AutoMapper;
using WebApi.ViewModels.Payment;

namespace WebApi.AutoMapperProfiles
{
    public class PaymentProfile : Profile
    {
        public PaymentProfile()
        {
            CreateMap<GetStudentPaymentDto, GetStudentPaymentViewModel>();
            CreateMap<PayLessonsViewModel, PayLessonsCommand>();
            CreateMap<GetStudentPaymentFilterViewModel, GetStudentPaymentListQuery>();
        }
    }
}
