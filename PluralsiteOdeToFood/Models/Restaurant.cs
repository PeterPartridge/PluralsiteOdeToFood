using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PluralsiteOdeToFood.Models
{
    public class Restaurant
    {
        public int id { get; set; }
        [Required, Display(Name = "Restaurant Name")]
        [MinLength(3)]
        public string name { get; set; }
        public CusineType Cusine { get; set; }

    }
}
