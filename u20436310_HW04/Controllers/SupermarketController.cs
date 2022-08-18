using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using u20436310_HW04.Models;

namespace u20436310_HW04.Controllers
{
    public class SupermarketController : Controller
    {
        public IActionResult Index()
        {
            List<Supermarket> supermarketslist = new List<Supermarket>();

            Supermarket supermarket1 = new Supermarket("https://flash.za.com/wp-content/uploads/1970/01/boxer-superstores1.jpg", "Boxer Superstores", "Boxer is one of the fastest growing discount supermarkets in Southern Africa. With a cemented set of ‘people centered’ goals and values, we have positioned ourselves as ‘Africa’s Favourite Discount Supermarket’ - a discounter that caters for the needs of the enlarged middle to lower income consumer market. Since our beginnings, more than four decades ago in 1977, in KwaZulu-Natal’s Empangeni community, the Boxer brand has grown far and wide and includes well defined retail offerings that boast stores spread in every province of South Africa, as well as in the Kingdom of eSwatini (Swaziland).");
            Supermarket supermarket2 = new Supermarket("https://cdn-prd-02.pnp.co.za/sys-master/images/h26/h64/10206546133022/pick-n-pay-header2.png", "Pick 'n Pay", "Pick n Pay is the quintessential family store focused on the customer. Since 1967 when consumer champion Raymond Ackerman purchased the first few stores, the Ackerman family’s vision has grown and expanded to now encompass stores in South Africa, Namibia, Botswana, Zambia, Mozambique, Mauritius, Swaziland and Lesotho. Additionally Pick n Pay owns a 49% share of a Zimbabwean supermarket business, TM Supermarkets. Our offer to customers focuses on groceries, clothing and general merchandise, but also includes additional value-added services to cater for our customers’ expectations and evolving needs. To ensure a convenient and accessible shopping experience the Group operates across multiple store formats, both franchised and owned.");

            supermarketslist.Add(supermarket1);
            supermarketslist.Add(supermarket2);

            return View(supermarketslist);
        }
    }
}
