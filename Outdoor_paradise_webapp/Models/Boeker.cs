using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class Boeker{
        [Key]
        public int Customer { get; set; }
        public string IBAN { get; set; }
        public DateTime Birth_date { get; set; }
        public string sex { get; set; }
    }
}
