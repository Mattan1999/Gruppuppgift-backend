using System.Collections.Generic;
using Gruppuppgift_backend.Entities;

namespace Gruppuppgift_backend.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        // Car GetCar(int id);
        void UpdateCar(Car car);
        void DeleteCar(int id);
        void AddCar(Car car);
    }
}
