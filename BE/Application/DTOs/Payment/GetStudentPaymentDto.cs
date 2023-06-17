using Domain.Enums;

namespace Application.DTOs.Payment
{
    public sealed class GetStudentPaymentDto
    {
        public DateTimeOffset Date { get; set; }
        public decimal Sum { get; set; }
        public PaymentMethod Method { get; set; }
        public string AddedBy { get; set; }
        public int StudentId { get; set; }
    }
}
