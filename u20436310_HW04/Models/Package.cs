using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using u20436310_HW04.Data;

namespace u20436310_HW04.Models
{
    public class Package
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public string ImageURL { get; set; }
        public DateTime SellDate { get; set; }
        public DateTime BestBefore { get; set; }
        public PackageType PackageType { get; set; }

        //Relationships between models
        public List<Package_Provider> Package_Providers { get; set; }

        public Farmer Farmer { get; set; }
        public Supermarket Supermarket {get; set;}

        //package constructor
        public Package(string pname, string pdes, string pimage, double pcost, DateTime psellby, DateTime pbb)
        {
            pname = Name;
            pdes = Description;
            pimage = ImageURL;
            pcost = Cost;
            psellby = SellDate;
            pbb = BestBefore;
        }
    }
}
