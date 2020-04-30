﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyShopSolution.Data.EF
{
    public class MyShopDbContextFactory : IDesignTimeDbContextFactory<MyShopDbContext>
    {
        public MyShopDbContext CreateDbContext(string[] args)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("MyShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<MyShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MyShopDbContext(optionsBuilder.Options);
        }
    }
}
