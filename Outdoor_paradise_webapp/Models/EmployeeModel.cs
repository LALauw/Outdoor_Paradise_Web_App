using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
namespace Outdoor_paradise_webapp.Models {
    public class EmployeeModel {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string FullName { get {
                return First_name + " " + Last_name;
            } }
        public string Email { get; set; }
        public string Work_phone { get; set; }
        public string Status { get; set; }
        public string Ssn { get; set; }
        public double Salary { get; set; }  
        public string Birth_date { get; set; }
        public int Manager { get; set; }
        public string Manager_fname { get; set; }
        public string Manager_lname { get; set; }
        public string Job { get; set; }
        public string Postition { get; set; }
        public string Department { get; set; }
        public string ManagerName { get {
                return Manager_fname + " " + Manager_lname;
            } }
    }
}
