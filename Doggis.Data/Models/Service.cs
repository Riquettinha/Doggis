﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doggis.Data.Models
{
    public class Service
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public TimeSpan EstimatedTime { get; set; }
        public decimal Price { get; set; }
        public Enums.User.UserType Responsable { get; set; }
        public int PatazGiven { get; set; }
        public int PatazPrice { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<ServicePriceHistory> ServicePriceHistories { get; set; }
        public virtual ICollection<ServiceSchedule> ServiceSchedules { get; set; }

        public Service()
        {
            ServicePriceHistories = new List<ServicePriceHistory>();
            ServiceSchedules = new List<ServiceSchedule>();
        }
    }
}
