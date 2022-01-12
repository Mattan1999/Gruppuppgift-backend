using Gruppuppgift_backend.Repositories;
using Microsoft.AspNetCore.Mvc;

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
    }
}
