using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u20436310_HW04.Models
{
    public class Package_Provider
    {
        public int Package_Id { get; set; }
        public Package Movie { get; set; }

        public int FarmerId { get; set; }
        public Farmer Farmer { get; set; }

        public int SupermarketId { get; set; }
        public Supermarket Supermarket { get; set; }
    }
}
