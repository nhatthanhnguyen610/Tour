using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Base
{
    public class TypeTicketModel : DefaultModel
    {
        public decimal Id { get; set; }
        public string type { get; set; }
        public decimal price { get; set; }
        public int stock { get; set; }
        public int flightId { get; set; }
        public int totalRows { get; set; }
        public int totalPages { get; set; }
    }
}
