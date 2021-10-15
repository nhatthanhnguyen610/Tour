using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Tour.Admin.Models;
using Tour.Base;
using Tour.Common.Constants;
using Tour.Service;

namespace Tour.Admin.Controllers
{
    public class FlightController : BaseController
    {
        IFlightService _FlightService;
        public FlightController()
        {
            _FlightService = new FlightService(string.Empty);
        }
        public IActionResult Index()
        {
            var vm = new FlightVM();
            try
            {
                var model = new SysUsrUserFilterModel();
                vm.p = vm.p == 0 ? 1 : vm.p;
                model.pageIndex = vm.p;
                model.pageSize = DefinedConstants.RowPerPage;
                var _listFlight = _FlightService.GetList(model);
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
        public PartialViewResult _Index(FlightVM vm)
        {
            try
            {
                ViewBag.Paging = vm.p;
                var viewModel = vm.ConvertObject<FlightVM, SysUsrUserFilterModel>();
                viewModel.pageIndex = vm.p == 0 ? 1 : vm.p;
                viewModel.pageSize = DefinedConstants.RowPerPage;
                vm.ListFlight = _FlightService.GetList(viewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return PartialView(vm);
        }

        /// <summary>
        ///  Author: dtr
        ///  Description: Tạo chuyến bay mới
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public IActionResult _Create()
        {
            return View(new FlightViewModel());
        }

        /// <summary>
        ///  Author: dtr
        ///  Description:  Tạo chuyến bay mới
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _Create(FlightViewModel vm)
        {
            var model = vm.ConvertObject<FlightViewModel, FlightModel>();
            try
            {
                model.createdBy = Constants.UserCde;
                if (!string.IsNullOrWhiteSpace(model.name))
                {
                    var submitResult = _FlightService.InsertFlight(model);
                    return Json(new
                    {
                        IsSuccess = submitResult,
                        Message = submitResult ? ResultStatus.SUCCESS : ResultStatus.FAIL
                    });
                }
                else
                {
                    return Json(new
                    {
                        IsSuccess = false,
                        Message = ResultStatus.FAIL
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    IsSuccess = false,
                    Message = ResultStatus.ERROR
                });
            }
        }

        /// <summary>
        ///  Author: dtr
        ///  Description: cập nhật chuyến bay
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public IActionResult _Update(decimal flightID)
        {
            var vm = new FlightViewModel();
            try
            {
                var _lstFlight = _FlightService.GetInfo(flightID);
                vm = _lstFlight.ConvertObject<FlightModel, FlightViewModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(vm);
        }
        /// <summary>
        ///  Author: dtr
        ///  Description: cập nhật chuyến bay
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _Update(FlightViewModel vm)
        {
            var model = vm.ConvertObject<FlightViewModel, FlightModel>();
            try
            {
                model.createdBy = Constants.UserCde;
                if (!string.IsNullOrWhiteSpace(model.name))
                {
                    var submitResult = _FlightService.UpdateFlight(model);
                    return Json(new
                    {
                        IsSuccess = submitResult,
                        Message = submitResult ? ResultStatus.SUCCESS : ResultStatus.FAIL
                    });
                }
                else
                {
                    return Json(new
                    {
                        IsSuccess = false,
                        Message = ResultStatus.FAIL
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    IsSuccess = false,
                    Message = ResultStatus.ERROR
                });
            }
        }
        /// <summary>
        /// DeleteSysNews
        /// </summary>
        /// <param name="pFlightID"></param>
        /// <param name="pRowVersion"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(decimal pFlightID)
        {
            FlightModel model = new FlightModel()
            {
                Id = pFlightID,
            };
            var submitResult = _FlightService.DeleteFlight(model);
            return Json(new
            {
                IsSuccess = submitResult,
                Message = submitResult ? ResultStatus.SUCCESS : ResultStatus.FAIL
            });
        }
    }
}
