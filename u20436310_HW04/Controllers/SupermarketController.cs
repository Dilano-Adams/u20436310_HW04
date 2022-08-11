using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u20436310_HW04.Controllers
{
    public class SupermarketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
