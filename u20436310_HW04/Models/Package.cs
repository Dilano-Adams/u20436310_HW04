using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using u20436310_HW04.Data;

namespace u20436310_HW04.Models
{
    public class Package
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime SellDate { get; set; }
        public DateTime BestBefore { get; set; }
        public PackageType PackageType { get; set; }
    }
}
