namespace Application.DTOs.Instructor
{
    public sealed class InstructorProfileDto
    {
        public int Id { get; set; }
        public int? PhotoId { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public string CarName { get; set; }
        public string RegistrationNumber { get; set; }
        public string Spot { get; set; }
    }
}
