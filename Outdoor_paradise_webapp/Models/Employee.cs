using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class Employee {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip_code { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Sex { get; set; }
        public string Work_phone { get; set; }
        public string Status { get; set; }
        public string Ssn { get; set; }
        public double Salary { get; set; }
        public DateTime Date_hired { get; set; }
        public DateTime Termination_date { get; set; }
        public DateTime Birth_date { get; set; }
        public string Bene_health_ins { get; set; }
        public string Bene_life_ins { get; set; }
        public string Bene_day_care { get; set; }
        public string Position_en { get; set; }
        public string Extension { get; set; }
        public string Acces_level { get; set; }
        public int? Manager { get; set; }
        public int? Department { get; set; }
        public int? Sales_branch { get; set; }
        public int? Job { get; set; }
    }
}
