using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Admin.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Tên đăng nhập")]
        public string userName { get; set; }

        [Required]
        [Display(Name = "Mật khẩu")]
        public string password { get; set; }

        [Display(Name = "Ghi nhớ đăng nhập")]
        public bool isRemember { get; set; }

        public string errorMessage { get; set; }
    }
    public class ChangePassViewModel
    {
        [Required]
        [Display(Name = "Mật khẩu cũ")]
        public string passwordOld { get; set; }
        [Required]
        [Display(Name = "Mật khẩu mới")]
        public string passwordNew { get; set; }
        [Required]
        [Display(Name = "Nhập lại mật khẩu")]
        public string passwordConfirm { get; set; }
        public string errorMessage { get; set; }
    }
    public class SysUsrUserVM
    {
        public SysUsrUserVM()
        {
            ListUser = new List<SysUsrUserModel>();
        }
        public int p { get; set; }
        public string keyWord { get; set; }
        public List<SysUsrUserModel> ListUser { get; set; }
        public int TotalRows
        {
            get
            {
                return ListUser != null ? (ListUser.Count > 0 ? ListUser.First().totalRows : 0) : 0;
            }
        }
    }
    public class SysUsrUserViewModel
    {
        public decimal userID { get; set; }
        public string fullName { get; set; }
        public DateTime? birthday { get; set; }
        public DateTime birthdayView { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string userCode { get; set; }
        public string address { get; set; }
        public string avatar { get; set; }
        public bool isActive { get; set; }
    }
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
}
