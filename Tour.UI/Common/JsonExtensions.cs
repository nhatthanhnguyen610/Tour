using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tour.UI
{
    public static class JsonExtensions
    {
        /// <summary>
        /// Parse string to JSON
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str">The string.</param>
        /// <returns></returns>
       
        public static string ToJSON(this object obj)
        {
            try
            {
                return JsonConvert.SerializeObject(obj);
                //JavaScriptSerializer serializer = new JavaScriptSerializer();
                //return serializer.Serialize(obj);
            }
            catch (System.Exception)
            {
                return string.Empty;
            }
        }

    }
}
