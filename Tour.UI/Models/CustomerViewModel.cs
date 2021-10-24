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

    public class CustomerViewModel
    {
        public decimal Id { get; set; }
        [Required(ErrorMessage = "Họ và tên không được bỏ trống")]
        public string fullName { get; set; }
        public DateTime? birthday { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        [Required(ErrorMessage ="Tên đăng nhập không được bỏ trống")]
        public string username { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được bỏ trống")]
        public string password { get; set; }
        public string address { get; set; }
        public string avatar { get; set; }
    }
}
