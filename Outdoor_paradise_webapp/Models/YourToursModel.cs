using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class YourToursModel {
        public Reis Reis { get; set; }
        public List<Boeking> Boekingen { get; set; }
        public List<Reis_uitvoeringModel> Reis_uitvoeringen { get; set; }
        public Boeker Boeker { get; set; }
        public Customer Customer { get; set; }
    }
}
