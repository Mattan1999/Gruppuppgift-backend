using Gruppuppgift_backend.Dtos;
using Gruppuppgift_backend.Entities;

namespace Gruppuppgift_backend
{
    public static class Extension
    {
        public static CarDto AsDto(this Car car)
        {
            return new CarDto
            {
                Id = car.Id,
                Model = car.Model,
                CarDealership = car.Dealership.Id
            };
        }
    }
}

