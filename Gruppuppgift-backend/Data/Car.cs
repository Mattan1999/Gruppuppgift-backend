namespace Gruppuppgift_backend.Entities
{
    public class Car
    {

        public int Id { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Price { get; set; }

        public CarDealership Dealership { get; set; }
    }

}
