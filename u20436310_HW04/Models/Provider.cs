using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace u20436310_HW04.Models
{
    public class Provider
    {
        [Display (Name ="Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        [Display(Name ="Biography")]
        public string Bio { get; set; }

        public Provider() : base() { }
    }
}
