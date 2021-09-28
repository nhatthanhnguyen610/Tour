using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Admin.Models
{
    public class SysUsrRoleViewModel
    {
        public SysUsrRoleViewModel()
        {
            ListSysUsrRole = new List<SysUserRoleModel>();
        }
        public string userCde { get; set; }
        public List<SysUserRoleModel> ListSysUsrRole { get; set; }
    }


}
