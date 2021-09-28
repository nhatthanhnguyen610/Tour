using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Admin.Models
{
    public class SysCustomerVM
    {
        public SysCustomerVM()
        {
            ListCustomer = new List<SysCustomerModel>();
        }
        public int p { get; set; }
        public string keyWord { get; set; }
        public List<SysCustomerModel> ListCustomer { get; set; }
        public int TotalRows
        {
            get
            {
                return ListCustomer != null ? (ListCustomer.Count > 0 ? ListCustomer.First().totalRows : 0) : 0;
            }
        }
    }

    public class SysCustomerViewModel
    {
        public decimal Id { get; set; }
        public string fullName { get; set; }
        public DateTime? birthday { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string avatar { get; set; }
    }
}
