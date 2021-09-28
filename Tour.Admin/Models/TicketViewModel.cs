using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Admin.Models
{
    public class TicketVM
    {
        public TicketVM()
        {
            ListTicket = new List<TicketModel>();
        }
        public int p { get; set; }
        public string keyWord { get; set; }
        public List<TicketModel> ListTicket { get; set; }
        public List<FlightModel> ListFlight { get; set; }
        public List<TypeTicketModel> ListTTicket { get; set; }
        public List<SysCustomerModel> ListCustomer { get; set; }
        public int TotalRows
        {
            get
            {
                return ListTicket != null ? (ListTicket.Count > 0 ? ListTicket.First().totalRows : 0) : 0;
            }
        }
    }

    public class TicketViewModel
    {
        public decimal Id { get; set; }
        public int userId { get; set; }
        public int flightId { get; set; }
        public int TTicketId { get; set; }
        public int TTicketIdChange { get; set; }
    }
}
