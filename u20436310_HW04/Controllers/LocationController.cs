using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using u20436310_HW04.Models;

namespace u20436310_HW04.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            List<Location> locationslist = new List<Location>();

            Location location1 = new Location(".",".",".",".",".");

            locationslist.Add(location1);
            return View(locationslist);
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
