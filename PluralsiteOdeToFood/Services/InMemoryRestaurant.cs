using PluralsiteOdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluralsiteOdeToFood.Services
{
    public class InMemoryRestaurant : IRestaurantData
    {
        public InMemoryRestaurant()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant { id = 1, name = "Peters Pizza" },
                new Restaurant { id = 2, name = "Julies Chinese" },
                new Restaurant { id = 3, name = "Bobs HotDogs" }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.id);
        }

   

        List<Restaurant> _restaurants;
    }
}
