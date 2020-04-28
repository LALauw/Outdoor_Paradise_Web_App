using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class Excursie {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public double Prijs { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int Gids { get; set; }
    }
}
