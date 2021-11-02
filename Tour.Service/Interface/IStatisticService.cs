using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Service
{
    public interface IStatisticService
    {
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách thống kê
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<StatisticModel> GetList(int year);
    }
}
