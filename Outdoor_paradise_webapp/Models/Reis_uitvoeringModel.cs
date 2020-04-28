using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class Reis_uitvoeringModel : Reis_uitvoering{
        public Reis ReisObj { get; set; }
        public List<ExcursieIndexModel> Excursies { get; set; }
        public List<Medereiziger> Medereizigers { get; set; }
        public double TotaalPrijs { get; set; }
        public int CountExcursies { get; set; }
        public int boeker { get; set; }
        public int countBookings { get; set; }
    }
}
