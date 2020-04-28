using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class Reis {
        public int Id { get; set; }
        public string Locatie { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Kind { get; set; }
        public int Max_deelnemers { get; set; }
        public int Min_deelnemers { get; set; }
        public int Image { get; set; }
    }
}
