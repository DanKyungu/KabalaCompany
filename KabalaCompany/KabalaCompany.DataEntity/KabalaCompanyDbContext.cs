using System;
using Microsoft.EntityFrameworkCore;

namespace KabalaCompany.DataEntity
{
    public class KabalaCompanyDbContext:DbContext
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
            optionsBuilder.UseSqlServer("DefaultConnection");
        }

    }
}
