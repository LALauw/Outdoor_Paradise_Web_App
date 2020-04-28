using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class Reis_uitvoeringCreateModel : Reis_uitvoering{
        public List<Reis> Reizen { get; set; }
        public List<Excursie> Excursies { get; set; }
        public List<ExcursieIndexModel> ExcursiesModel { get; set; }
        public double TotaalPrijs { get; set; }
    }
}
