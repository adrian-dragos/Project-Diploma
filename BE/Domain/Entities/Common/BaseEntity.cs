using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Common
{
    public class BaseEntity
    {
        public int Id { get; init; }

        [Required]
        public DateTimeOffset CreatedAt { get; set; }

        [Required]
        [MaxLength(100)]
        public string CreatedBy { get; set; }

        public DateTimeOffset? LastModifiedAt { get; set; }

        [MaxLength(100)]
        public string? LastModifiedBy { get; set; }

    }
}
