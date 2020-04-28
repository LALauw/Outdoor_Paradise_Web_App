using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Outdoor_paradise_webapp.Models {
    public class RegisterBoekerViewModel {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string IBAN { get; set; }

        [Required]
        public DateTime Birth_date { get; set; }

        [Required]
        public string Sex { get; set; }
    }
}
