namespace Domain.Entities
{
    public sealed class Review : BaseEntity
    {
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
        public string Description { get; set; }
    }
}
