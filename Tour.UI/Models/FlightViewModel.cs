using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.UI.Models
{
    public class FlightViewModel
    {
        public decimal Id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public DateTime? date { get; set; }
        public string duaration { get; set; }
        public int stock { get; set; }
        public decimal tigia { get; set; }
    }
}
