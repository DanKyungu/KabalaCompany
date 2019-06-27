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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>()
                           .HasOne(r => r.LastEditedBy)
                           .WithMany(r => r.Orders)
                           .HasForeignKey(r => r.LastEditedById)
                           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PurchaseOrderLines>()
                        .HasOne(r => r.PurchaseOrder)
                        .WithMany(r => r.PurchaseOrderLines)
                        .HasForeignKey(r => r.PurchaseOrderId)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PurchaseOrders>()
                        .HasOne(r => r.User)
                        .WithMany(r => r.UserPurchaseOrders)
                        .HasForeignKey(r => r.UserId)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderLines>()
                        .HasOne(r => r.Order)
                        .WithMany(r => r.OrderLines)
                        .HasForeignKey(r => r.OrderId)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Supplier>()
                        .HasOne(r => r.PrimaryContactPerson)
                        .WithMany(r => r.PrimarySuppliers)
                        .HasForeignKey(r => r.PrimaryContactPersonId)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Supplier>()
                        .HasOne(r => r.AlternativeContactPerson)
                        .WithMany(r => r.AlternativeSuppliers)
                        .HasForeignKey(r => r.AlternativeContactPersonId)
                        .OnDelete(DeleteBehavior.Cascade);
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
