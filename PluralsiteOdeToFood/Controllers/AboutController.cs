using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PluralsiteOdeToFood.Controllers
{
    // about 

    [Route("[controller]/[action]")]
    public class AboutController : Controller
    {
        // empty string makes controller point to this route.
        [Route("")]
        public string Phone()
        {
            return " Call the builder on : 01524 865 445";
        }

        [Route("[action]")]
        public string Address()
        {
            return "UK";
        }
    }
}