﻿using Doggis.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Doggis.Services
{
    public interface IServiceService
    {
        IEnumerable<Service> Get();
    }
}