using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Admin.Models
{
    public class FlightVM
    {
        public FlightVM()
        {
            ListFlight = new List<FlightModel>();
        }
        public int p { get; set; }
        public string keyWord { get; set; }
        public List<FlightModel> ListFlight { get; set; }
        public int TotalRows
        {
            get
            {
                return ListFlight != null ? (ListFlight.Count > 0 ? ListFlight.First().totalRows : 0) : 0;
            }
        }
    }

    public class FlightViewModel
    {
        public decimal Id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public DateTime? date { get; set; }
        public string duaration { get; set; }
    }
}
