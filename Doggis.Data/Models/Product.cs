﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doggis.Data.Models
{
    public class Product
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public int Inventory { get; set; }
        public int Category { get; set; }

    }
}
