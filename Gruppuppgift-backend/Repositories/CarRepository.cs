using System.Collections.Generic;
using Gruppuppgift_backend.Entities;

namespace Gruppuppgift_backend.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly List<Car> _carList = new List<Car>()
            {
                new Car() { Id = 1, Manufacturer = "BMW", Model = "i8", Color = "White", Price = 1000000},
                new Car() { Id = 1, Manufacturer = "Tesla", Model = "x8", Color = "White", Price = 800000 },
                new Car() { Id = 1, Manufacturer = "Toyota", Model = "Prius", Color = "White", Price = 60000 },
            };

        public IEnumerable<Car> GetCars()
        {
            return _carList;
        }

        // public Car GetCar(int id)
        // {
        //     var car = _carList.Where(e => e.Id == id);
        //     return car.SingleOrDefault();
        // }


        // public Car GetCar(int id)
        // {
        //     // var car = _dogList.Where(e => e.Id == id);
        //     var car = _dogList.FindIndex(w => w.Id == id);
        //     return car.SingleOrDefault();
        // }

        public void UpdateCar(Car car)
        {
            var index = _carList.FindIndex(e => e.Id == car.Id);
            _carList[index] = car;

        }
        public void DeleteCar(int id)
        {
            Car index = _carList.Find(e => e.Id == id);
            _carList.Remove(index);
        }
        public void AddCar(Car car)
        {
            _carList.Add(car);
        }

    }


}
