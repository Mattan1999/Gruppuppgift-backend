using Gruppuppgift_backend.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Gruppuppgift_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class CarsController : ControllerBase
    {
        private readonly ICarRepository _repository;

        public CarsController(ICarRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]

        public IEnumerable<Car> GetCars()
        {
            return _repository.GetCars();
        }

        [HttpGet("{id}")]

        public ActionResult<Car> GetCar(int id)
        {
            var car = _repository.GetCar(id);

            if (car == null)
                return NotFound();

            return Ok(car);
        }

        [HttpPost]
        public ActionResult AddCar(Car c)
        {


            bool res = _repository.AddCar(c);
            if (!res)
                return BadRequest();
            return CreatedAtAction(nameof(AddCar), c);
        }
        [HttpPut("{id}")]

        public ActionResult UpdateCar(Car c, int id)
        {
            var existingCar = _repository.GetCar(id);

            if (existingCar == null)
                return NotFound();

            existingCar.Price = c.Price;
            bool res = _repository.UpdateCar(existingCar);
            if (!res)
                return BadRequest();
            return Ok();
        }
        [HttpDelete("{id}")]

        public ActionResult DeleteCar(int id)
        {
            var car = GetCar(id);
            if (car == null)
                return NotFound();

            bool res = _repository.DeleteCar(id);

            if (!res)
                return BadRequest();

            return NoContent();
        }
    }
}