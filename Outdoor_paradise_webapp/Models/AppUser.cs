using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class AppUser : IdentityUser{
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Full_name { get {
                return First_name + " " + Last_name;
            } }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Company_name { get; set; }
    }
}
