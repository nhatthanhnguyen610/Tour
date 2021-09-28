using Microsoft.AspNetCore.Authorization;
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
    public class NewsController : BaseController
    {
        INewsService _sysNewsService;
        public NewsController()
        {
            _sysNewsService = new NewsService(string.Empty);
        }
        public IActionResult Index()
        {
            var vm = new NewsVM();
            try
            {
                var model = new SysUsrUserFilterModel();
                vm.p = vm.p == 0 ? 1 : vm.p;
                model.pageIndex = vm.p;
                model.pageSize = DefinedConstants.RowPerPage;
                var _listNews = _sysNewsService.GetList(model);
                vm.ListNews = _listNews;
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
        public PartialViewResult _Index(NewsVM vm)
        {
            try
            {
                ViewBag.Paging = vm.p;
                var viewModel = vm.ConvertObject<NewsVM, SysUsrUserFilterModel>();
                viewModel.pageIndex = vm.p == 0 ? 1 : vm.p;
                viewModel.pageSize = DefinedConstants.RowPerPage;
                vm.ListNews = _sysNewsService.GetList(viewModel);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return PartialView(vm);
        }

        /// <summary>
        ///  Author: dtr
        ///  Description: Tạo bài viết mới
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public IActionResult _Create()
        {
            return View(new NewsViewModel());
        }

        /// <summary>
        ///  Author: dtr
        ///  Description:  Tạo bài viết mới
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult _Create(NewsViewModel vm)
        {
            var model = vm.ConvertObject<NewsViewModel, NewsModel>();
            model.createdBy = Constants.UserCde;
            try
            {
                if (!string.IsNullOrWhiteSpace(model.title))
                {
                    var submitResult = _sysNewsService.InsertSysNews(model);
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
        ///  Description: cập nhật
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public IActionResult _Update(decimal newsID)
        {
            var vm = new NewsViewModel();
            try
            {
                var _lstMenu = _sysNewsService.GetInfo(newsID);
                vm = _lstMenu.ConvertObject<NewsModel, NewsViewModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(vm);
        }
        /// <summary>
        ///  Author: dtr
        ///  Description: cập nhật
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult _Update(NewsViewModel vm)
        {
            var model = vm.ConvertObject<NewsViewModel, NewsModel>();
            model.createdBy = Constants.UserCde;
            try
            {
                if (!string.IsNullOrWhiteSpace(model.title))
                {
                    var submitResult = _sysNewsService.UpdateSysNews(model);
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
        /// <param name="pmenuID"></param>
        /// <param name="pRowVersion"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(decimal newsID)
        {
            NewsModel model = new NewsModel()
            {
                newsId = newsID,
            };
            var submitResult = _sysNewsService.DeleteSysNews(model);
            return Json(new
            {
                IsSuccess = submitResult,
                Message = submitResult ? ResultStatus.SUCCESS : ResultStatus.FAIL
            });
        }
    }
}
