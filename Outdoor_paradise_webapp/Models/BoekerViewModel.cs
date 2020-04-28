using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class BoekerViewModel : Boeker{
        public string Username { get; set; }
        public bool isBooker { get; set; }
    }
}
