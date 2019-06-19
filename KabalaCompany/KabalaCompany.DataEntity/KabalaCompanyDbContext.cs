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
    }
}
