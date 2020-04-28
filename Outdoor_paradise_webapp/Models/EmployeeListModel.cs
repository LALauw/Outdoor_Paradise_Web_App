using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Outdoor_paradise_webapp.Models {
    public class EmployeeListModel {
        public IPagedList<EmployeeModel> Employees { get; set; }
    }
}
