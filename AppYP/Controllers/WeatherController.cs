using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DataAccess.Concrete;

namespace AppYP.Controllers
{
    public class WeatherController : Controller
    {
        WeatherRepository weatherRepository = new WeatherRepository();
        List<string> lastCities = new List<string> { "London", "Istanbul", "Berlin", "Paris" };

        public IActionResult Index()
        {
            foreach (var city in lastCities)
            {
                weatherRepository.Add(weatherRepository.FindNewByName(city));
            }
            return View(weatherRepository.GetAll());
        }

        [HttpPost]
        public JsonResult GetCities()
        {
            return Json(weatherRepository.GetAll());
        }

        [HttpPost]
        public JsonResult SearchWeather(string city)
        {
            return Json(weatherRepository.FindNewByName(city));
        }

    }
}
