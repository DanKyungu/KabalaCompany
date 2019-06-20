using Microsoft.EntityFrameworkCore;
using System;

namespace KabalaCompany.DataEntity
{
    public class KabalaCompanyDbContext : DbContext
    {
        public KabalaCompanyDbContext()
        {
            
        }

        public KabalaCompanyDbContext(DbContextOptions<KabalaCompanyDbContext> options)
            :base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-LR9GDC4\\DSSQLEXPRESS;Database=KabalaCompanyDb;Integrated Security=True");
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
