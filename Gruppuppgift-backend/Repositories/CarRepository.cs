using Gruppuppgift_backend.Data;
using Gruppuppgift_backend.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gruppuppgift_backend.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _context;
        public CarRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Car> GetCars()
        {
            return _context.Cars.Include(c => c.Price).ToList();
        }

        public Car GetCar(int id)
        {
            return _context.Cars.Include(c => c.Price).FirstOrDefault(x => x.Id == id);

        }
        public bool AddCar(Car c)
        {
            try
            {
                _context.Cars.Add(c);
                var res = _context.SaveChanges();

                string response = "Succesfully created a Car" + res;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error when adding Car", e.Message);
                return false;
            }
            return true;
        }
        public bool UpdateCar(Car c)
        {
            try
            {
                var Car = _context.Cars.SingleOrDefault(existingCar => existingCar.Id == c.Id);
                _context.Entry(Car).CurrentValues.SetValues(c);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
                throw new Exception(e.Message);
            }
            return true;
        }

        public bool DeleteCar(int id)
        {
            try
            {
                var Car = _context.Cars.SingleOrDefault(existingCar => existingCar.Id == id);
                _context.Cars.Remove(Car);
                _context.SaveChanges();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return true;
        }
    }
}