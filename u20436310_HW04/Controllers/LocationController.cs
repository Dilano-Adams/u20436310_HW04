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

            Location location1 = new Location("https://image.shutterstock.com/image-photo/durban-kwazulu-natal-south-africa-600w-1708786963.jpg", "178 Gerorge Street","Umhlanga Rocks","KwaZulu-Natal","Central location of the First For Woman refugee camp.");
            Location location2 = new Location("https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/South_Africa-Johannesburg-Hillbrow001.jpg/800px-South_Africa-Johannesburg-Hillbrow001.jpg", "51 Fairlady Way", "Hillbrow", "Gauteng", "Homeless Shelter catering for all.");

            locationslist.Add(location1);
            locationslist.Add(location2);
            return View(locationslist);
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
