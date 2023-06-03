using Domain.Enums;

namespace WebApi.ViewModels.Payment
{
    public sealed class GetStudentPaymentViewModel
    {
        public DateTimeOffset Date { get; set; }
        public decimal Sum { get; set; }
        public PaymentMethod Method { get; set; }
        public string AddedBy { get; set; }
    }
}
