
using System;
using System.Data.Entity;

namespace KabalaCompany.DataEntity
{
    public class KabalaCompanyContext : DbContext
    {
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>()
                        .HasRequired(r => r.LastEditedBy)
                        .WithMany(r => r.Orders)
                        .HasForeignKey(r => r.LastEditedById)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orders>()
                        .HasRequired(r => r.Customer)
                        .WithMany(r => r.Orders)
                        .HasForeignKey(r => r.CustomerId)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseOrderLines>()
                        .HasRequired(r => r.PurchaseOrder)
                        .WithMany(r => r.PurchaseOrderLines)
                        .HasForeignKey(r => r.PurchaseOrderId)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseOrders>()
                        .HasRequired(r => r.User)
                        .WithMany(r => r.UserPurchaseOrders)
                        .HasForeignKey(r => r.UserId)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderLines>()
                        .HasRequired(r => r.Order)
                        .WithMany(r => r.OrderLines)
                        .HasForeignKey(r => r.OrderId)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                        .HasRequired(r => r.PrimaryContactPerson)
                        .WithMany(r => r.PrimarySuppliers)
                        .HasForeignKey(r => r.PrimaryContactPersonId)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                        .HasRequired(r => r.AlternativeContactPerson)
                        .WithMany(r => r.AlternativeSuppliers)
                        .HasForeignKey(r => r.AlternativeContactPersonId)
                        .WillCascadeOnDelete(false);
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
