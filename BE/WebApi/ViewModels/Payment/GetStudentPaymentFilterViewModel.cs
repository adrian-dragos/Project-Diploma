using Domain.Enums;

namespace WebApi.ViewModels.Payment
{
    public class GetStudentPaymentFilterViewModel
    {
        public IEnumerable<int> StudentIds { get; set; }
        public IEnumerable<PaymentMethod> PaymentMethod { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
    }
}
