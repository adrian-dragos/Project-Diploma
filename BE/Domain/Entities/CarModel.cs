using Domain.Entities.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public sealed class CarModel : BaseEntity
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public string Color { get; set; }
        public CarGear CarGear { get; set; }
        public ICollection<Car> Cars { get; set; }

    }
}
