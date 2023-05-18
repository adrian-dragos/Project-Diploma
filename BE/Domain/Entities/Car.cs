using Domain.Entities.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public sealed class Car : BaseEntity
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public string Color { get; set; }
        public string Vin { get; set; }
        public string RegistrationNumber { get; set; }
        public CarGear CarGear { get; set; }
        public IEnumerable<InstructorCar> InstructorCars { get; set; }
    }
}
