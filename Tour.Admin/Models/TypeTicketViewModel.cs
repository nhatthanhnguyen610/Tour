using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Admin.Models
{
    public class TypeTicketVM
    {
        public TypeTicketVM()
        {
            ListTTicket = new List<TypeTicketModel>();
        }
        public int p { get; set; }
        public string keyWord { get; set; }
        public List<TypeTicketModel> ListTTicket { get; set; }
        public int TotalRows
        {
            get
            {
                return ListTTicket != null ? (ListTTicket.Count > 0 ? ListTTicket.First().totalRows : 0) : 0;
            }
        }
    }

    public class TypeTicketViewModel
    {
        public decimal Id { get; set; }
        public string type { get; set; }
        public decimal price { get; set; }
    }
}
