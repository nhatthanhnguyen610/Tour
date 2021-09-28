using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Base
{
    public class SysCustomerModel : DefaultModel
    {
        public decimal Id { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public DateTime? birthday { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string avatar { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int totalRows { get; set; }
        public int totalPages { get; set; }
    }
}
