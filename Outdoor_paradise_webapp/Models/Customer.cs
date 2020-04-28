using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class Customer {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Company_name { get; set; }
        public double? Discount { get; set; }
        public int? Max_quantity_order { get; set; }
        public string Typecode { get; set; }
        public int? Manager { get; set; }
        public string Username { get; set; }
    }
}
