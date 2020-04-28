using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class ReisViewModel : Reis{
        public Image ImagePath { get; set; }
        public List<Reis_uitvoeringModel> Uitvoeringen { get; set; }
    }
}
