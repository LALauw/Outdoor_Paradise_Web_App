using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class Manager {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string FullName { get { return First_name + " " + Last_name; } }
    }
}
