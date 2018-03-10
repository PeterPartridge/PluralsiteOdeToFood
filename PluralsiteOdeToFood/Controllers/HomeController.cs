using Microsoft.AspNetCore.Mvc;
using PluralsiteOdeToFood.Models;
using PluralsiteOdeToFood.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluralsiteOdeToFood.Controllers
{
    public class HomeController :Controller
    {
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public IActionResult Index()
        {
            //  Restaurant model = new Restaurant { id = 1, name = "Peters Pizza" };

            //  return Content("Hello from the home Controller");

            List<Restaurant> modelList = _restaurantData.GetAll().ToList();

            return View(modelList);
        }
    }
}
