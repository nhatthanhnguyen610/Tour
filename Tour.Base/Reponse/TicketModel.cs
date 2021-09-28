using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Base
{
    public class TicketModel : DefaultModel
    {
        public decimal Id { get; set; }
        public int userId { get; set; }
        public int flightId { get; set; }
        public int TTicketId { get; set; }
        public int TTicketIdChange { get; set; }
        public int totalRows { get; set; }
        public int totalPages { get; set; }
    }
}
