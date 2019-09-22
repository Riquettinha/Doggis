﻿using Doggis.Data.Enum;
using System;
using System.Collections.Generic;

namespace Doggis.Data.Models
{
    public class Order
    {
        public Guid ID { get; set; }
        public string ProtocolNumber { get; set; }
        public bool Paid { get; set; }
        public int PaymentType { get; set; }
        public string TotalPrice { get; set; }
    }
}