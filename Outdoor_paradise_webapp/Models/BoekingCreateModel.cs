using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class BoekingCreateModel : Boeking{
        public Reis Reis { get; set; }
        public Reis_uitvoering Reis_Uitvoering { get; set; }
        public Customer Customer { get; set; }
        public Boeker Boekende { get; set; }
        public double TotaalPrijs { get; set; }
        public int Aantal { get; set; }
        public List<Medereiziger> Medereizigers { get; set; }
    }
}
