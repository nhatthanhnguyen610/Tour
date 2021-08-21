using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Base
{
    public class DefaultModel
    {
        [FromQuery]
        public string createdBy { get; set; }
    }
}
