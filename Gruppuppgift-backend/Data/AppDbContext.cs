using Gruppuppgift_backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gruppuppgift_backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDealership> CarDealership { get; set; }
    }


}