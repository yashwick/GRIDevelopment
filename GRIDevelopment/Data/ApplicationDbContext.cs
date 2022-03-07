using GRIDevelopment.Models;
using Microsoft.EntityFrameworkCore;

namespace GRIDevelopment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ): base(options)
        {

        }

        public DbSet<Product> products { get; set; }
        
    }
}
