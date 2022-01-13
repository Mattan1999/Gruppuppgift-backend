using Gruppuppgift_backend.Entities;
using System.Collections.Generic;

namespace Gruppuppgift_backend.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCar(int id);
        bool UpdateCar(Car car);
        bool DeleteCar(int id);
        bool AddCar(Car car);
    }
}
