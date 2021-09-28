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
}
