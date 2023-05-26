using Domain.Entities.Common;

namespace Domain.Entities
{
    public sealed class Car : BaseEntity
    {
        public int CarModelId { get; set; }
        public CarModel CarModel { get; set; }
        public string Vin { get; set; }
        public string RegistrationNumber { get; set; }
        public IEnumerable<InstructorCar> InstructorCars { get; set; }
    }
}
