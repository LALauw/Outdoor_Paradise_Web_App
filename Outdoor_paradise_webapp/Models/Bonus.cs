using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class Bonus {
        public int Id { get; set; }
        public int Employee { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
    }
}
