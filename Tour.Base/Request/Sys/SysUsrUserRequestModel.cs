using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Base
{
    public class LoginRequestModel
    {
        public string email { get; set; }
        public string passWord { get; set; }
    }
    public class SysUsrUserFilterModel
    {
        public string keyWord { get; set; }
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
    public class RequestChangePassModel
    {
        public string userCde { get; set; }
        public string passWordNew { get; set; }
        public string passWordOld { get; set; }
        public string passWordConfirm { get; set; }
    }
}
