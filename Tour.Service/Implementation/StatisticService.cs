using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;
using Tour.Provider;

namespace Tour.Service
{
    public class StatisticService : IStatisticService
    {
        IStatisticProvider _statisticProvider;
        public StatisticService(string appId, string userId = "0")
        {
            _statisticProvider = new StatisticProvider(appId, userId);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách thống kê
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<StatisticModel> GetList(int year)
        {
            return _statisticProvider.GetList(year);
        }
    }
}
