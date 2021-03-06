﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doggis.Data.Repository
{
    public class ProductRepository : RepositoryBase<Doggis.Data.Models.Product>, IProductRepository
    {
        private readonly DoggisContext _context;

        public ProductRepository(DoggisContext context) : base(context)
        {
            _context = context;
        }
    }
}
