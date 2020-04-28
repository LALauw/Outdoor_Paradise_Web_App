using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class Reis_uitvoering {
        public int Id { get; set; }
        public DateTime Begin_datum { get; set; }
        public DateTime Eind_datum { get; set; }
        public double Prijs_per_deelnemer { get; set; }
        public int Reis { get; set; }
    }
}
