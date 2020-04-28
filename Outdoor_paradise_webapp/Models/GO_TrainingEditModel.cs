using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class GO_TrainingEditModel : GO_TrainingModel{
        public List<Course> Courses { get; set; }
        public List<EmployeeModel> Employees { get; set; }
    }
}
