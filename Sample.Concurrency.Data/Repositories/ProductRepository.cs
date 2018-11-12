using Microsoft.EntityFrameworkCore;
using Sample.Concurrency.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Concurrency.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
