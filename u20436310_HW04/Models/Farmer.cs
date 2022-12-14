using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u20436310_HW04.Models
{
    public class Farmer : Provider
    {
        public int FarmerId { get; set; }
        public Farmer(string FProfilePictureURL, string FFullName, string FBio)
        {
            ProfilePictureURL = FProfilePictureURL;
            FullName = FFullName;
            Bio = FBio;
        }
        public Farmer(): base() { }
    }
}
