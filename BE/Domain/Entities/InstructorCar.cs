namespace Domain.Entities
{
    public sealed class InstructorCar : BaseEntity
    {
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}
