using Domain.Enums;

namespace WebApi.ViewModels.Payment
{
    public class PayLessonsViewModel
    {
        public int StudentId { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
