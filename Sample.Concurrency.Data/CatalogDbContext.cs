using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sample.Concurrency.Data.Entities;
using Sample.Concurrency.Data.Entities.Configurations;

namespace Sample.Concurrency.Data
{
    public class CatalogDbContext : DbContext
    {
        private readonly ILoggerFactory loggerFactory;

        public CatalogDbContext(DbContextOptions<CatalogDbContext> options)
         : base(options)
        {
        }

        public CatalogDbContext(DbContextOptions<CatalogDbContext> options, ILoggerFactory loggerFactory)
          : base(options)
        {
            this.loggerFactory = loggerFactory;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(loggerFactory);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ProductConfiguration());
        }

        public DbSet<Product> Products { get; set; }
    }
}
