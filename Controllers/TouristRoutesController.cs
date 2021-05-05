using FakeXiecheng.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXiecheng.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristRoutesController : ControllerBase
    {
        private ITouristRouteRepository touristRouteRepository;
        public TouristRoutesController(ITouristRouteRepository _touristRouteRepository)
        {
            touristRouteRepository = _touristRouteRepository;
        }
        [HttpGet]
        public IActionResult GetTouristRoutes()
        {
            var routes = touristRouteRepository.GetTouristRoutes();
            return Ok(routes);
        }
    }
}
