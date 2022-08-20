using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using u20436310_HW04.Models;

namespace u20436310_HW04.Controllers
{
    public class PackageController : Controller
    {
        public IActionResult Index()
        {
            List<Package> packageslist = new List<Package>();

            Package package1 = new Package("Chicken Deluxe Package","Delicious Chicken", "https://www.shopriteholdings.co.za/content/dam/MediaPortal/article1/2022/new-rotisserie-chicken-boxes-/new-rotisserie-chicken-boxes.jpg/jcr:content/renditions/cq5dam.web.1280.1280.jpeg", 65.99, new DateTime(2022,08,19), new DateTime(2022,08,22));
            Package package2 = new Package("Full Soup Package", "Soup that is ready made.", "https://www.eatwell101.com/wp-content/uploads/2020/02/chicken-soup-recipe-3.jpg", 40.99, new DateTime(2022, 08, 21), new DateTime(2022, 08, 24));
            Package package3 = new Package("Fresh Produce Package", "Full package with vaying produce", "https://images.unsplash.com/photo-1464226184884-fa280b87c399?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80", 25.40, new DateTime(2022, 08, 15), new DateTime(2022, 08, 20));
            Package package4 = new Package("Turducken", "Turkey, duck and chicken", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F6045938.jpg", 420.00, new DateTime(2022, 08, 20), new DateTime(2022, 08, 24));

            packageslist.Add(package1);
            packageslist.Add(package2);
            packageslist.Add(package3);
            packageslist.Add(package4);

            return View(packageslist);
        }
        public IActionResult Details()
        {
            List<Farmer> farmers = new List<Farmer>();
            return View(farmers);
        }
    }
}
