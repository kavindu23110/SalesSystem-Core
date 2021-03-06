﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SalesSystem.BLL.DBContextFactory
{
    public class SalesDbContextFactory
    {

        public SalesSystem.DAL.SalessystemContext CreateDbContext()
        {
            var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
            var connectionString = configuration
                 .GetConnectionString("DefaultConnection");
            var optionsBuilder = new DbContextOptionsBuilder<SalesSystem.DAL.SalessystemContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new SalesSystem.DAL.SalessystemContext(optionsBuilder.Options);
        }

    }
}
