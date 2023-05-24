namespace WebApi.ViewModels.Instructor
{
    public sealed class InstructorProfileViewModel
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
