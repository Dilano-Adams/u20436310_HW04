using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using u20436310_HW04.Models;

namespace u20436310_HW04.Controllers
{
    public class FamerController : Controller
    {
        public IActionResult Index()
        {
            List<Farmer> farmerslist = new List<Farmer>();

            Farmer farmer1 = new Farmer("https://i.kym-cdn.com/photos/images/newsfeed/001/445/963/523.jpg", "John's Produce", "John Williams is a 40-year-old tea maker who enjoys duck herding, eating and football. He is friendly and gentle, but can also be very sadistic and a bit unintelligent. He is addicted to chocolate, something which his friend Lulu Thea Morrison pointed out when he was 15.The problem intensified in 2001.John has lost two jobs as a result of his addiction, specifically: golf caddy and kitchen assistant.He is an Australian Christian who defines himself as straight.He finished school and then left academia.");
            Farmer farmer2 = new Farmer("https://media.istockphoto.com/photos/portrait-of-farmer-standing-in-soybean-field-at-sunset-picture-id1198012795", "Fred's Farm", "Fred Powell is a 40-year-old golf caddy who enjoys listening to music, duck herding and worship. He is friendly and gentle, but can also be very sadistic and a bit unintelligent. He is addicted to video games, something which his friend Keiran Quinn Gibson pointed out when he was 17.The problem intensified in 2001.In 2016, Fred lost his job as a trainee tradesperson as a result of his addiction.He is an American Christian who defines himself as straight.He finished school and then left academia.");
            Farmer farmer3 = new Farmer("https://media.istockphoto.com/id/493551400/photo/winemaker-in-vineyard.webp?s=612x612&w=is&k=20&c=UjLaBoV4jmzjNasdKKm2ZkkfjRz2SbOS38fcP8pnHJA=", "Timmy's Livestock and Produce", "Timmy Anderson is a 61-year-old town counsellor who enjoys eating out, meditation and playing card games. He is kind and inspiring, but can also be very cowardly and a bit disloyal. He is an American Christian who defines himself as straight.He finished school and then left academia.He is obsessed with organic vegetables.Physically, Timmy is slightly overweight but otherwise in good shape.He is tall with cocao skin, black hair and brown eyes.");

            farmerslist.Add(farmer1);
            farmerslist.Add(farmer2);
            farmerslist.Add(farmer3);

            return View(farmerslist);
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
