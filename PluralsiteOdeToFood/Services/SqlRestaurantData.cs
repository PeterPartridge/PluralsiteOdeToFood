using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PluralsiteOdeToFood.Models;
using PluralsiteOdeToFood.Data;

namespace PluralsiteOdeToFood.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private OdeTofoodDbContext _context;

        public SqlRestaurantData(OdeTofoodDbContext context)
        {
            _context = context;
        }
        public Restaurant Add(Restaurant newRestraunt)
        {
            _context.Restaurants.Add(newRestraunt);
            _context.SaveChanges();
            return newRestraunt;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants.OrderBy(r => r.name);
        }

        public Restaurant GetRestaurant(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.id == id);
        }

        public Restaurant Update(Restaurant restaurant)
        {
           _context.Attach(restaurant).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return restaurant;
        }
    }
}
