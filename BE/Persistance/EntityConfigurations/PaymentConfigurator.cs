using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    internal sealed class PaymentConfigurator : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder
                .HasOne(sl => sl.Student)
                .WithMany(s => s.Payments)
                .HasForeignKey(sl => sl.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(sl => sl.Lesson)
                .WithMany(l => l.Payments)
                .HasForeignKey(sl => sl.LessonId);

            builder.HasData(GetPayments());
        }

        private IReadOnlyCollection<Payment> GetPayments()
        {

            var paidLessons = new int[]
            {
                3, 9, 15, 21, 27, 33, 39, 45, 51, 57, 63, 69, 75, 81, 87, 93, 99, 105, 111, 117,
                123, 129, 135, 141, 147, 153, 159, 165, 171, 177, 195, 201, 207, 213, 219, 225,
                231, 237, 243, 249, 255, 267, 285, 291, 297, 303, 309, 315, 321, 327, 333
            };

            var random = new Random(42);
            var payments = new List<Payment>();
            var date = new DateTime(2023, 6, 1, 11, 50, 43, 880, DateTimeKind.Utc).AddTicks(7923);
            var paymentMethod = PaymentMethod.Cash;
            var createdBy = "Joe Doe";
            var hour = random.Next(8, 23);
            var minute = random.Next(1, 60);

            for (int i = 1, day = 1, month = 6; i < paidLessons.Length; i++)
            {
                if (i % 7 == 0)
                {

                    if (day != 29)
                    {
                        day += 7;
                        hour = random.Next(8, 23);
                        minute = random.Next(1, 60);
                    }

                    if (day == 29)
                    {
                        paymentMethod = PaymentMethod.Card;
                        createdBy = "Sarah Johnson";
                    }
                }
                date = new DateTime(2023, month, day, hour, minute, 43, 880, DateTimeKind.Utc).AddTicks(7923);

                var payment = new Payment
                {
                    StudentId = 1,
                    LessonId = paidLessons[i - 1],
                    CreatedAt = date,
                    CreatedBy = createdBy,
                    Method = paymentMethod,
                    Id = i
                };
                payments.Add(payment);
            }

            return payments;
        }
    }
}
