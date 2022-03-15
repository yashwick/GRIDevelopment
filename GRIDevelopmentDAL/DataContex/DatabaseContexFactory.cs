using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace GRIDevelopmentDAL.DataContex
{
    public class DatabaseContexFactory : IDesignTimeDbContextFactory<DatabseContext>
    {
        public DatabseContext CreateDbContext(string[] args)
        {
            AppConfiguration appConfig = new AppConfiguration();
            var opsBuilder = new DbContextOptionsBuilder<DatabseContext>();
            opsBuilder.UseSqlServer(appConfig.sqlConnectionString);
            return new DatabseContext(opsBuilder.Options);
        }
    }
}
