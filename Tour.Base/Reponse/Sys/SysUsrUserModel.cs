using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Base 
{
    public class SysUsrUserModel : DefaultModel
    {
        public decimal userID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
        public string userCode { get; set; }
        public string email { get; set; }
        public DateTime? birthday { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string avatar { get; set; }
        public bool? isActive { get; set; }
        public int totalRows { get; set; }
        public int totalPages { get; set; }
    }
}
