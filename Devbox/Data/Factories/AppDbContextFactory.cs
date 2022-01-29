using Devbox.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devbox.Data.Factories
{
    internal class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        private IDataService _dataService;

        public AppDbContextFactory(IDataService dataService)
        {
            _dataService = dataService;
        }

        public AppDbContext CreateDbContext(string[] args = null)
        {
            var conString = _dataService.GetConnectionString();
            var connStr = conString.ConnectionString;
            var options = new DbContextOptionsBuilder<AppDbContext>();

            options.UseNpgsql(connStr);

            return new AppDbContext(options.Options);
        }
    }
}
