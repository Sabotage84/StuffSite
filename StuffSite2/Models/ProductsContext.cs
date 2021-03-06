﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StuffSite2.Models
{
    public class ProductsContext: DbContext
    {
        public ProductsContext(): base("ProductsDB")
        { }

        public DbSet<Product> Products { get; set; }
    }
}