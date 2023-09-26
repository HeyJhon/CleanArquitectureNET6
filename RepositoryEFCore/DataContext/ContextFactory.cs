using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFCore.DataContext
{
    class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;database=CADemoDb");

            return new Context(optionsBuilder.Options);
        }
    }
}
