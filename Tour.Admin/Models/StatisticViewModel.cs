using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Tour.Admin.Models
{
    [DataContract]
    public class StatisticViewModel
    {
        public StatisticViewModel(decimal Price, string DateMonth)
        {
            this.Price = Price;
            this.DateMonth = DateMonth;
        }
        [DataMember(Name = "y")]
        public Nullable<decimal> Price { get; set; }
        [DataMember(Name = "label")]
        public string DateMonth { get; set; }
    }

    public class StatisticVM
    {
        public int year { get; set; }
    }
        
}
