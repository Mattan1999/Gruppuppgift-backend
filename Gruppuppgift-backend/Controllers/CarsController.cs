using Gruppuppgift_backend.Repositories;
using Microsoft.AspNetCore.Mvc;
using Gruppuppgift_backend.Entities;
using System.Collections.Generic;

namespace Gruppuppgift_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarRepository _repository;

        public CarsController(ICarRepository repo)
        {
            _repository = repo;
        }

        [HttpGet]

        public IEnumerable<Car> GetCars()
        {
            var cars = _repository.GetCars();
            return cars;
        }

        // [HttpGet("{id}")]

        // public ActionResult<Car> GetCar(int id)
        // {
        //     var dog = _repository.GetCar(id);

        //     if (dog == null)
        //     {
        //         return NotFound();
        //     }
        //     return Ok(dog);
        // }

        // [HttpPut("{id}")]
        // public ActionResult UpdateDog(Car car, int id)
        // {
        //     // var selectedCar = _repository.GetCar(id);
        //     var selectedCar = _repository.GetCar(id);
        //     if (selectedCar == null)
        //     {
        //         return NotFound();
        //     }
        //     // selectedCar = car.Model;
        //     _repository.UpdateCar(selectedCar);
        //     return Ok();
        // }

        [HttpDelete("{id}")]
        public ActionResult DeleteDog(int id)
        {
            _repository.DeleteCar(id);
            return NoContent();
        }

        // [HttpPost]
        // public ActionResult<Car> AddCar(Car car)
        // {
        //     Car nCar = new Car()
        //     {
        //         Id = car.Id,
        //         Model = car.Model,
        //         Manufacturer = car.Manufacturer,
        //         Color = car.Color,
        //         Price = car.Price,
        //         Dealership = car.Dealership
        //     };
        //     _repository.AddCar(car);
        //     return CreatedAtAction(nameof(GetCar), new { id = car.Id }, car);
        // }
    }
}
