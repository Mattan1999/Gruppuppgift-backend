using System.Collections.Generic;
using Gruppuppgift_backend.Entities;

namespace Gruppuppgift_backend.Repositories
{
    public interface ICarDealershipRepository
    {
        // IEnumerable<Car> GetCar();
        // Car GetCar(int id);
        // void UpdateCar(Car car);
        // void DeleteCar(int id);
        // void AddCar(Car car);
        void UpdateName(CarDealership name);
        void DeleteCardelership(int id);

        void AddDealership(CarDealership carDealership);
    }
}
