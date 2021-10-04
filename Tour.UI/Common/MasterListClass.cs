using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Tour.UI
{
    public static class MasterListClass
    {
        /// <summary>
        /// Convert object A to Object B
        /// </summary>
        /// <typeparam name="T">Source Object</typeparam>
        /// <typeparam name="T2">Des Objects</typeparam>
        /// <param name="Objecj">inputObject</param>
        /// <returns>output object</returns>
        public static T2 ConvertObject<T, T2>(this T Objecj) where T : new() where T2 : new()
        {
            //Type sourceType = Objecj.GetType();
            //var obj1 = Objecj.ToJSON();
            //return obj1.FromJSON<T2>();
            Type sourceType = Objecj.GetType();
            var objDest = Activator.CreateInstance<T2>();
            Type targetType = objDest.GetType();
            //  Loop through the source properties
            var properties = typeof(T2).GetProperties();
            foreach (var p in properties)
            {
                //  Get the matching property in the destination object
                PropertyInfo targetObj = targetType.GetProperty(p.Name);
                //  If there is none, skip
                if (targetObj == null)
                    continue;
                //  Set the value in the destination
                PropertyInfo sourceObj = sourceType.GetProperty(p.Name);
                if (sourceObj == null)
                    continue;
                targetObj.SetValue(objDest, sourceObj.GetValue(Objecj, null), null);
            }
            return objDest;
        }
    }
}
