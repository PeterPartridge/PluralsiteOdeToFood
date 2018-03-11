using PluralsiteOdeToFood.Models;
using System.Collections.Generic;

namespace PluralsiteOdeToFood.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string MessageOfTheDay { get; set; }
    }
}
