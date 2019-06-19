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
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=THEPC\\SQLSERVER;Database=KabalaCompanyDb;Trusted_Connection=True;");
        }

        public virtual DbSet<Employee> Employee{get; set;}
    }
}
