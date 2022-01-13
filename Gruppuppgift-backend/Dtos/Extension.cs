﻿

namespace Gruppuppgift_backend.Dtos
{
    public static class Extension
    {
        public static CarDto AsDto(this Car car)
        {
            return new CarDto
            {
                Id = car.Id,
                Model = car.Model,
                CarDealership = car.CarDealership
            };
        }
    }
}
