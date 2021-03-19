using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiCountry.Models
{
    public class Country
    {
        [Key]
        public string Name { get; set; }
        [Required]
        public string Capital { get; set; }
        public int Population { get; set; }
        public double Latlng { get; set; }
        public string Timezones { get; set; }
        public Currency Currencies { get; set; }
        public string Flag { get; set; }
    }
}
