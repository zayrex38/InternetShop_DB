using System;
using System.Collections.Generic;
using System.Text;

namespace Electronics_Shop.Data
{

    using Microsoft.EntityFrameworkCore;
    public class DeaneryContext : DbContext
    {
        public DbSet<couriers> CouriersTable { get; set; }
        public DbSet<Customers> CustomersTable { get; set; }
        public DbSet<orders> OrdersTable { get; set; }
        public DbSet<products> ProductsTable { get; set; }

        public DbSet<sold_products> Sold_ProductsTable { get; set; }

        protected override void
    OnConfiguring(DbContextOptionsBuilder options)

            => options.UseSqlite("Data source=deanery.db");
    }
}
