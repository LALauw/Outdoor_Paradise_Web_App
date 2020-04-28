using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class Boeking {
        public int Boeker { get; set; }
        public int Reis_uitvoering { get; set; }
        public DateTime Datum { get; set; }
    }
}
