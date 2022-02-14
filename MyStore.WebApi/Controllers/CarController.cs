using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyStore.Service;
using MyStore.Entity;

namespace MyStore.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private ICarService carService;
        public CarController(ICarService carService)
        {
            this.carService = carService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(Car car)
        {
            carService.AddCar(car);
            return Ok();
        }

    }
}
