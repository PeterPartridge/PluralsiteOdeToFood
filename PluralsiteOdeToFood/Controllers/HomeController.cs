using Microsoft.AspNetCore.Mvc;
using PluralsiteOdeToFood.Models;
using PluralsiteOdeToFood.Services;
using PluralsiteOdeToFood.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluralsiteOdeToFood.Controllers
{
    public class HomeController :Controller
    {
        private IRestaurantData _restaurantData;
        private IGreeter _greet;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greet = greeter;
        }

        public IActionResult Index()
        {
            //  Restaurant model = new Restaurant { id = 1, name = "Peters Pizza" };

            //  return Content("Hello from the home Controller");

            // List<Restaurant> modelList = _restaurantData.GetAll().ToList();

            HomeIndexViewModel model = new HomeIndexViewModel();

            model.Restaurants = _restaurantData.GetAll();
            model.MessageOfTheDay = _greet.MessageOfTheDay();
           
            return View(model);
        }

        public IActionResult Details(int id)
        {
            Restaurant model = _restaurantData.GetRestaurant(id);

            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View (model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RestrauntEditModel restaurant)
        {
            if (ModelState.IsValid)
            {
                var newRestraunt = new Restaurant();
                newRestraunt.name = restaurant.Name;
                newRestraunt.Cusine = restaurant.Cusine;

                newRestraunt = _restaurantData.Add(newRestraunt);
                return RedirectToAction(nameof(Details), new { id = newRestraunt.id });
            }
            else
            {

                return View();
            }
        }

    }
}
