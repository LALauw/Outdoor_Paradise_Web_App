using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class EmployeeEditModel {
        public int Id { get; set; }
        public string Ssn { get; set; }
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
        public int? Job { get; set; }
        public int? Manager { get; set; }
        public string Manager_fname { get; set; }
        public string Manager_lname { get; set; }
        public string Department { get; set; }
        public List<Department> Departments {get;set;}
        public List<Job> Jobs { get; set; }
        public List<EmployeeModel> Employees { get; set; }
        public List<Manager> Managers { get; set; }
        public int? DepartmentNumber { get; set; }
        public string ManagerName {
            get {
                return Manager_fname + " " + Manager_lname;
            }
        }
    }
}
