using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Tour.Base;
using Tour.Common.Constants;
using Tour.Service;
using Tour.UI;
using Tour.UI.Controllers;
using Tour.UI.Models;


namespace UI.Controllers
{
    public class HomeController : BaseController
    {
        ISysCustomerService _sysCustomerService;

        public HomeController()
        {
            _sysCustomerService = new SysCustomerService(string.Empty);
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(new LoginViewModel());
        }
        /// <summary>
        ///  Author: dtr
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
                    return View("Index", new LoginViewModel()
                    {
                        errorMessage = ResultStatus.UserLoginNull
                    });
                }
                var infoMemer = _sysCustomerService.LoginSys(
                   new LoginRequestModel()
                   {
                       passWord = viewModel.password,
                       email = viewModel.userName
                   });
                if (infoMemer != null)
                {
                    Constants.FullName = infoMemer.fullName;
                    Constants.Password = infoMemer.password;
                    Constants.Avatar = infoMemer.avatar == null ? Constants.No_Image : infoMemer.avatar;
                    string strData = infoMemer.ToJSON();
                    HttpContext.Session.SetString(DefinedConstants.SessionUser, strData);
                    return RedirectToAction("Index", "Home");
                }
                viewModel.errorMessage = ResultStatus.UserLoginFail;
                return View("Index", viewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [AllowAnonymous]
        public IActionResult Tour()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Doitac()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
