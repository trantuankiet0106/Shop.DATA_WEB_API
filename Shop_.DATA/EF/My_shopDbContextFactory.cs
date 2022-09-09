using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace My_shop.Data.EF
{
    public class My_shopDbContextFactory : IDesignTimeDbContextFactory<EDBcontext>
    {
        public EDBcontext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("My_shopDb");

            var optionsBuilder = new DbContextOptionsBuilder<EDBcontext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new EDBcontext(optionsBuilder.Options);
        }
    }
}
