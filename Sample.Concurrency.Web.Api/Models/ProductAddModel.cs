﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Concurrency.Web.Api.Models
{
    public class ProductAddModel
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }
    }
}
