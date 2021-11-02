using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;
using Tour.Provider.Connection;
using static Tour.Provider.Connection.ConnectString;

namespace Tour.Provider
{
    public class StatisticProvider : ConnectSqlExecute, IStatisticProvider
    {
        public StatisticProvider(string appId, string userId)
           : base(ConnectCode.DBConnection, appId, userId)
        {

        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách thống kê
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<StatisticModel> GetList(int year)
        {
            var paramObj = new object[]
            {
                year
            };
            var resultComment = base.ExecProcedure<StatisticModel>("sp_Statistic_Thongke_V01", paramObj);
            if (resultComment.Any())
            {
                return resultComment.ToList();
            }
            return null;
        }
    }
}
