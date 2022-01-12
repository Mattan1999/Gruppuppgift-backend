using System.Collections.Generic;
using Gruppuppgift_backend.Entities;

namespace Gruppuppgift_backend.Repositories
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
    }
}
