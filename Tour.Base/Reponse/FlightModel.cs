using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Base
{
    public class FlightModel : DefaultModel
    {
        public decimal Id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public DateTime? date { get; set; }
        public string duaration { get; set; }
        public int totalRows { get; set; }
        public int totalPages { get; set; }
    }
}
