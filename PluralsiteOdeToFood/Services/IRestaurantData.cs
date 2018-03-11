﻿using PluralsiteOdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluralsiteOdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();

        Restaurant GetRestaurant(int id);
        Restaurant Add(Restaurant newRestraunt);
    }
}
