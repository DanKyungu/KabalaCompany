using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace KabalaCompany.DataEntity
{
    public class KabalaCompanyDbContext : DbContext
    {
        public IConfiguration Configuration { get; set; }

        public KabalaCompanyDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public KabalaCompanyDbContext(DbContextOptions<KabalaCompanyDbContext> options)
            :base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
