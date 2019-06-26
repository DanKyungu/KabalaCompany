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
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-LR9GDC4\\DSSQLEXPRESS;Database=KabalaCompanyDb;Trusted_Connection=True;");
        }

        public virtual DbSet<Animal> Animal { get; set; }
        public virtual DbSet<Animal> AnimalStock { get; set; }
        public virtual DbSet<AnimalSupplier> AnimalSupplier { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Employee> Employee {get; set;}
        public virtual DbSet<OrderLines> OrderLines {get; set; }
        public virtual DbSet<Orders> Order {get; set; }
        public virtual DbSet<PurchaseOrderLines> PurchaseOrderLines { get; set; }
        public virtual DbSet<PurchaseOrders> PurchaseOrder { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplierContactPerson> SupplierContactPerson { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
