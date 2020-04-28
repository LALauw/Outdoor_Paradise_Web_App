using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class Job {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public double Min_salary { get; set; }
        public double Max_salary { get; set; }
    }
}
