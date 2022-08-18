using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u20436310_HW04.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Logo { get; set; }

        public string StreetName { get; set; }

        public string City { get; set; }
        public string Province { get; set; }
        public string Description { get; set; }

        public Location(string logo, string sname, string city, string province, string desc)
        {
            Logo = logo;
            StreetName = sname;
            City = city;
            Province = province;
            Description = desc;
        }
    }
}
