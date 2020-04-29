using Microsoft.EntityFrameworkCore;
using MyShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyShopSolution.Data.EF
{
    public class MyShopDbContext : DbContext
    {
        public MyShopDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Categories { set; get; }
    }
}
