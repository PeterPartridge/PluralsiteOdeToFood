using PluralsiteOdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PluralsiteOdeToFood.ViewModels
{
    public class RestrauntEditModel
    {
    
        [Required,Display(Name = "Restraunt Name")]
        [MinLength(3)]
        public string Name { get; set; }
       
        public CusineType Cusine { get; set; }
    }
}
