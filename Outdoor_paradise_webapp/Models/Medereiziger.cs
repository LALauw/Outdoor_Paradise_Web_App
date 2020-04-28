using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class Medereiziger {
        public int Id { get; set; }
        public string Naam { get; set; }
        public DateTime BirthDate { get; set; }
        public string Sex { get; set; }
        public int Reis_uitvoering { get; set; }
    }
}
