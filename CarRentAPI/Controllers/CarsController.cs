using Microsoft.AspNetCore.Mvc;
using CarRentAPI.Models;
using System.Collections.Generic;

namespace CarRentAPI.Controllers
{
    [Route("api/[controller]")]
    public class CarsController : Controller
    {
        private CarsContext carsContext = new CarsContext();

        [Route("")]
        [Route("index")]
        public JsonResult Index()
        {
            var cars = carsContext.Cars;
            List<Cars> allCars = new List<Cars>();
            foreach(Cars car in cars){
                if (car.Car_Status == 0)
                    allCars.Add(car);
            }

            return Json(allCars);
        }

        [HttpGet]
        [Route("find/{id}")]
        public JsonResult Edit(int id)
        {
            return Json(carsContext.Cars.Find(id));
        }
    }
}