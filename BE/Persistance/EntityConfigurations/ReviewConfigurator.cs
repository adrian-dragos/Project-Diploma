using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    internal sealed class ReviewConfigurator : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.Property(x => x.Description)
            .HasMaxLength(500);

            builder.HasOne(r => r.Lesson)
            .WithOne(l => l.Review)
            .HasForeignKey<Lesson>(l => l.ReviewId);
        }
    }
}
