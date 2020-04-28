using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class Reis_uitvoeringEditModel : Reis_uitvoeringCreateModel {
        public List<ExcursieChecked> Excursiesheckbox { get; set; }
    }
}