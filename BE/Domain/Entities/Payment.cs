using Domain.Enums;

namespace Domain.Entities
{
    public sealed class Payment : BaseEntity
    {
        public int? StudentId { get; set; }
        public Student? Student { get; set; }

        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
        public PaymentMethod Method { get; set; }
        public DateTimeOffset Timestamp { get; set; }
    }
}
