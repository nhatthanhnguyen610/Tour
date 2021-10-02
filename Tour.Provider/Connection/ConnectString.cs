using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Provider.Connection
{
    public class ConnectString
    {
        public enum ConnectCode
        {
            DBConnection,
        }

        internal class ConnectName
        {
            public string Key { get; set; }
            public string Value { get; set; }
        }

        public static class UtilConnectString
        {
            /// <summary>
            /// 
            /// </summary>
            private static Dictionary<ConnectCode, ConnectName> _data = new Dictionary<ConnectCode, ConnectName>
            {
                {
                    ConnectCode.DBConnection,
                    new ConnectName
                    {
                        Key ="DBConnection",

                        Value ="Data Source=115.76.177.86,1433;Initial Catalog=Tour;User ID=sa;Password=123456;Connection Timeout=3000;"
                    }
                },
            };

            /// <summary>
            /// 
            /// </summary>
            /// <param name="cde"></param>
            /// <returns></returns>
            public static string GetConnectString(ConnectCode cde)
            {
                return _data.ContainsKey(cde) ? _data[cde].Value : string.Empty;
            }
        }
    }
}
