using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SalesSystem.BLL.DBContextFactory
{
    public class ApplicationDbContextFactory
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
