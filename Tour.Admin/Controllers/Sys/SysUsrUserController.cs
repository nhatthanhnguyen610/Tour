using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour.Admin.Models;
using Tour.Base;
using Tour.Common.Constants;
using Tour.Service;

namespace Tour.Admin.Controllers
{
    public class SysUsrUserController : BaseController
    {
        ISysUsrUserService _sysUsrUserService;
        public SysUsrUserController()
        {
            _sysUsrUserService = new SysUsrUserService(string.Empty);
        }
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        ///  Author: thanhnn
        ///  Description: Đăng nhập
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View(new LoginViewModel());
        }
        /// <summary>
        ///  Author: thanhnn
        ///  Description: Đăng nhập
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel viewModel)
        {
            try
            {

                if (viewModel.userName == null && viewModel.password == null)
                {
                    return View(new LoginViewModel()
                    {
                        errorMessage = "Người dùng hoặc tên đăng nhập không được để trống"
                    }) ;
                }
                var infoMemer = _sysUsrUserService.LoginSys(
                    new LoginRequestModel()
                    {
                        passWord = viewModel.password,
                        email = viewModel.userName
                    });
                if (infoMemer != null && infoMemer.userID > 0)
                {
                    Constants.UserCde = infoMemer.userCode;
                    Constants.FullName = infoMemer.fullName;
                    Constants.Avatar = infoMemer.avatar == null ? Constants.No_Image : infoMemer.avatar;
                    string strData = infoMemer.ToJSON();
                    HttpContext.Session.SetString(DefinedConstants.SessionUser, strData);
                    return RedirectToAction("Index", "Home");
                }
                viewModel.errorMessage = "Đăng nhập không thành công";
                return View(viewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
