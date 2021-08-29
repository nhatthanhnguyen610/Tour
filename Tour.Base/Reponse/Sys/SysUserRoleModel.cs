using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Base
{
    public class SysUserRoleModel : DefaultModel
    {
        public string userCde { get; set; }
        public string menuCde { get; set; }
        public string menuTitleCde { get; set; }
        public bool isSelected { get; set; }
    }

    public class SysMenuUserModel
    {
        public int id { get; set; }
        public string parentMenuCde { get; set; }
        public string menuCode { get; set; }
        public string menuTitleCde { get; set; }
        public string menuIcon { get; set; }
        public int orderBy { get; set; }
        public string actionOrClass { get; set; }
        public string controller { get; set; }
        public int totalRows { get; set; }
        public int totalPages { get; set; }

    }
}
