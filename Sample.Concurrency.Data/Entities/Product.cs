using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Concurrency.Data.Entities
{
    public class Product:BaseEntity
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }
    }
}
