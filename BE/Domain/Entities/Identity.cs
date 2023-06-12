using Domain.Entities.Authorization;

namespace Domain.Entities
{
    public sealed class Identity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateOnly? Birthday { get; set; }
        public int RoleId { get; set; } 
        public Role Role { get; set; }
        public ICollection<Student> Students { get; set;}
    }
}
