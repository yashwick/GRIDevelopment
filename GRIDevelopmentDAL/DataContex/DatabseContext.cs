using System;
using System.Collections.Generic;
using System.Text;
using GRIDevelopmentDAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GRIDevelopmentDAL.DataContex
{
    public class DatabseContext: IdentityDbContext<IdentityUser>
    {
        public class OptionsBuild
        {
            public OptionsBuild()
            {
                settings = new AppConfiguration();
                opsbuilder = new DbContextOptionsBuilder<DatabseContext>();
                opsbuilder.UseSqlServer(settings.sqlConnectionString);
                dbOptions = opsbuilder.Options;
            }
            public DbContextOptionsBuilder<DatabseContext> opsbuilder { get; set; }
            public DbContextOptions<DatabseContext> dbOptions { get; set; } 

            private AppConfiguration settings { get; set; }
        }

        public static OptionsBuild ops = new OptionsBuild();

        public DatabseContext(DbContextOptions<DatabseContext> options) : base(options) { }
        public DbSet<Admin> Admins { get; set; }
    }
}
