using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u20436310_HW04.Models
{
    public class Supermarket:Provider
    {
        public Supermarket(string SProfilePictureURL, string SFullName, string SBio)
        {
            ProfilePictureURL = SProfilePictureURL;
            FullName = SFullName;
            Bio = SBio;
        }
    }
}
