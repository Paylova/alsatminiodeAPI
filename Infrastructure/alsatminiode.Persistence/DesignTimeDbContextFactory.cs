using alsatminiode.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<alsatminiodeAPIDbContext>
    {
        public alsatminiodeAPIDbContext CreateDbContext(string[] args)
        {            
            DbContextOptionsBuilder<alsatminiodeAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString, options => options.EnableRetryOnFailure());
            return new alsatminiodeAPIDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
