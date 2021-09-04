using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Admin.Models
{
    public class SysMenuUserVM
    {
        public SysMenuUserVM()
        {
            ListMenuUser = new List<SysMenuUserModel>();
        }
        public int p { get; set; }
        public string keyWord { get; set; }
        public List<SysMenuUserModel> ListMenuUser { get; set; }
        public int TotalRows
        {
            get
            {
                return ListMenuUser != null ? (ListMenuUser.Count > 0 ? ListMenuUser.First().totalRows : 0) : 0;
            }
        }
    }
    public class SysMenuUserViewModel
    {
        public decimal menuId { get; set; }
        public string menuCde { get; set; }
        public string parentMenuCde { get; set; }
        public string menuTitleCde { get; set; }
        public string menuIcon { get; set; }
        public string actionOrClass { get; set; }
        public string controller { get; set; }
        public int orderBy { get; set; }
    }
}
