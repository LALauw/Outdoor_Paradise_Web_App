using Outdoor_paradise_webapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models{
    public class EmployeeCreateModel : Employee {
        public List<Department> Departments { get; set; }
        public List<Job> Jobs { get; set; }
        public List<Manager> Managers { get; set; }
    }
}
