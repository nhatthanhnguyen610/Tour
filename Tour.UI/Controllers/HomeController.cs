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
        IFlightService _flightService;
        ICommentService _commentService;
        ITicketService _ticketService;
        INewsService _newsService;

        public HomeController()
        {
            _sysCustomerService = new SysCustomerService(string.Empty);
            _flightService = new FlightService(string.Empty);
            _commentService = new CommentService(string.Empty);
            _ticketService = new TicketService(string.Empty);
            _newsService = new NewsService(string.Empty);
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            var r = new Random();
            ViewBag.Flight = _flightService.GetListUI().OrderBy(m => r.Next()).Take(6).ToList();

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
                    Constants.UserCde = infoMemer.Id.ToString();
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
            var vm = new FlightVM();
            try
            {
                var model = new SysUsrUserFilterModel();
                vm.p = vm.p == 0 ? 1 : vm.p;
                model.pageIndex = vm.p;
                model.pageSize = DefinedConstants.RowPerPage;
                var _listFlight = _flightService.GetList(model);
                vm.ListFlight = _listFlight;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return View(vm);
        }

        /// <summary>
        /// _Index
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        public IActionResult _Index(FlightVM vm)
        {
            try
            {
                ViewBag.Paging = vm.p;
                var viewModel = vm.ConvertObject<FlightVM, SysUsrUserFilterModel>();
                viewModel.pageIndex = vm.p == 0 ? 1 : vm.p;
                viewModel.pageSize = DefinedConstants.RowPerPage;
                vm.ListFlight = _flightService.GetList(viewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("Tour", vm);
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
        public IActionResult Info(decimal flightID)
        {
            var vm = new FlightViewModel();
            try
            {
                var _lstFlight = _flightService.GetInfo(flightID);
                vm = _lstFlight.ConvertObject<FlightModel, FlightViewModel>();
                ViewBag.News = _commentService.GetListNews().Where(m => m.flightId == flightID);
                ViewBag.Ticket = _ticketService.GetListTypeTicket();
                ViewBag.Comment = _newsService.GetListComment();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(vm);
        }
        public IActionResult Pay(decimal flightId)
        {
            try
            {
                ViewBag.Flight = _flightService.GetInfo(flightId);
                ViewBag.Ticket = _ticketService.GetListTypeTicket();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(new TicketViewModel());
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult _Pay(TicketViewModel vm)
        {
            var model = vm.ConvertObject<TicketViewModel, TicketModel>();
            model.userId = int.Parse(Constants.UserCde);
            model.createdBy = Constants.FullName;
            try
            {
                if (!string.IsNullOrWhiteSpace(model.userId.ToString()) && !string.IsNullOrWhiteSpace(model.flightId.ToString())
                    && !string.IsNullOrWhiteSpace(model.TTicketId.ToString()))
                {
                    model.TTicketIdChange = model.flightId;
                    var submitResult = _ticketService.InsertTicket(model) && _ticketService.ReduceStock(model.flightId);
                    if (submitResult)
                    {
                        return Redirect("Info?flightID=" + vm.flightId);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return View();
        }

        public IActionResult Register()
        {
            return View(new CustomerViewModel());
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult _Register(CustomerViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var model = vm.ConvertObject<CustomerViewModel, SysCustomerModel>();
                try
                {
                    model.createdBy = vm.fullName;
                    if (_sysCustomerService.IsEmailUsed(model))
                    {
                        return View("Register", vm);
                    }
                    if (!string.IsNullOrWhiteSpace(model.fullName) && !string.IsNullOrWhiteSpace(model.password) && !string.IsNullOrWhiteSpace(model.username))
                    {
                        var submitResult = _sysCustomerService.InsertSysCustomer(model);
                        if (submitResult)
                        {
                            return RedirectToAction("Index");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return View("Register", vm);
        }
        /// <summary>
        /// Logout
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Logout()
        {
            if (!string.IsNullOrWhiteSpace(HttpContext.Session.GetString(DefinedConstants.SessionUser)))
            {
                HttpContext.Session.Remove(DefinedConstants.SessionUser);
                Constants.FullName = null;
            }
            return Redirect("/Home/Index");
        }
    }
}
