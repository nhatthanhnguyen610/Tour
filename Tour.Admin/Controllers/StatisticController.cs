using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour.Admin.Models;
using Tour.Base;
using Tour.Service;

namespace Tour.Admin.Controllers
{
    public class StatisticController : BaseController
    {
        IStatisticService _statisticService;
        public StatisticController()
        {
            _statisticService = new StatisticService(string.Empty);
        }
        /// <summary>
        ///  Author: dtr
        ///  Editor: 
        ///  Modify date:
        ///  Description: Lấy danh sách thống kê
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        public IActionResult Index()
        {
            List<StatisticViewModel> model = new List<StatisticViewModel>();
            StatisticVM search = new StatisticVM();
            search.year = DateTime.Now.Year;
            try
            {
                var vm = new List<StatisticModel>();
                vm = _statisticService.GetList(DateTime.Now.Year);

                foreach (var item in vm)
                {
                    model.Add(new StatisticViewModel(item.Price, "Tháng " + item.DateMonth.ToString()));
                }

                ViewBag.data = JsonConvert.SerializeObject(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return View(search);
        }


        public ActionResult _Index(StatisticVM search)
        {
            List<StatisticViewModel> model = new List<StatisticViewModel>();
            try
            {
                var vm = new List<StatisticModel>();
                vm = _statisticService.GetList(search.year);

                if (vm == null)
                {
                    ViewBag.data = null;
                    return View("Index", search);
                }

                foreach (var item in vm)
                {
                    model.Add(new StatisticViewModel(item.Price, "Tháng " + item.DateMonth.ToString()));
                }

                ViewBag.data = JsonConvert.SerializeObject(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return View("Index", search);
        }

    }
}
