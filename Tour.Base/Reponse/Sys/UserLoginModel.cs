using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Base
{
    public class UserLoginModel
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
        public List<SysMenuOfUser> ListMenuOfUser { get; set; }
    }
    public class SysMenuOfUser
    {
        public string parentMenuCde { get; set; }
        public string menuCode { get; set; }
        public string menuTitleCde { get; set; }
        public string menuIcon { get; set; }
        public int orderBy { get; set; }
        public string actionOrClass { get; set; }
        public string controller { get; set; }
    }
}
