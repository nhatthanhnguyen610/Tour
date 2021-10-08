﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tour.UI.Models
{
    public class TicketViewModel
    {
        public decimal Id { get; set; }
        public int userId { get; set; }
        public int flightId { get; set; }
        public int TTicketId { get; set; }
        public int TTicketIdChange { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
    }
}
