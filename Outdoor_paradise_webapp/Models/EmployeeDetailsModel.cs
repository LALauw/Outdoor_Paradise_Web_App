using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class EmployeeDetailsModel {
        public int Id { get; set; }
        public string Ssn { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string FullName { get { return First_name + " " + Last_name; } }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip_code { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string Sex { get; set; }
        public string Work_phone { get; set; }
        public string Status { get; set; }
        public double Salary { get; set; }
        public string Date_hired { get; set; }
        public string Termination_date { get; set; }
        public string Birth_date { get; set; }
        public string Bene_health_ins { get; set; }
        public string Bene_life_ins { get; set; }
        public string Bene_day_care { get; set; }
        public string Position_en { get; set; }
        public string Extension { get; set; }
        public string Acces_level { get; set; }
        public string JobName { get; set; }
        public string Manager_fname { get; set; }
        public string Manager_lname { get; set; }
        public string Department { get; set; }
        public string ManagerName {
            get {
                return Manager_fname + " " + Manager_lname;
            }
        }
    }
}
