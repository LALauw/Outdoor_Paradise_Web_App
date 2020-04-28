using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class DepartmentDetailsModel : Department{
        public EmployeeModel EmployeeModel { get; set; }
    }
}
