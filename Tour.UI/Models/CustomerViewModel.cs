using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tour.UI.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Tên đăng nhập")]
        public string userName { get; set; }

        [Required]
        [Display(Name = "Mật khẩu")]
        public string password { get; set; }

        public string errorMessage { get; set; }
    }
}
