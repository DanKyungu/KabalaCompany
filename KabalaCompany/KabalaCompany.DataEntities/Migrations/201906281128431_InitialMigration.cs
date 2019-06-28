namespace KabalaCompany.DataEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Warehouse.Animal",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnimalName = c.String(nullable: false, maxLength: 60),
                        MinimumWeight = c.Int(nullable: false),
                        MaximumWeight = c.Int(nullable: false),
                        PricePerKg = c.Double(nullable: false),
                        RetailPricePerKg = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Warehouse.AnimalStock",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        LastEditedWhen = c.DateTime(nullable: false),
                        AnimalId = c.Int(nullable: false),
                        LastEditedById = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Warehouse.Animal", t => t.AnimalId, cascadeDelete: true)
                .ForeignKey("Application.User", t => t.LastEditedById, cascadeDelete: true)
                .Index(t => t.AnimalId)
                .Index(t => t.LastEditedById);
            
            CreateTable(
                "Application.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 60),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sales.PurchaseOrderLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 100),
                        OrderQuantity = c.Int(nullable: false),
                        UnitPrice = c.Int(nullable: false),
                        LastEditedWhen = c.DateTime(nullable: false),
                        PurchaseOrderId = c.Int(nullable: false),
                        AnimalId = c.Int(nullable: false),
                        LastEditedById = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Warehouse.Animal", t => t.AnimalId, cascadeDelete: true)
                .ForeignKey("Purchasing.PurchaseOrders", t => t.PurchaseOrderId)
                .ForeignKey("Application.User", t => t.LastEditedById, cascadeDelete: true)
                .Index(t => t.PurchaseOrderId)
                .Index(t => t.AnimalId)
                .Index(t => t.LastEditedById);
            
            CreateTable(
                "Purchasing.PurchaseOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        ExpectedDeliveryDate = c.DateTime(nullable: false),
                        IsOrderCompleted = c.Boolean(nullable: false),
                        IsOrderFinalizedOnTime = c.Boolean(nullable: false),
                        Comments = c.String(nullable: false, maxLength: 60),
                        LastEditedWhen = c.DateTime(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        OrderPlacedById = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        LastEditedById = c.Int(nullable: false),
                        OrdersPlaced_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sales.Orders", t => t.OrdersPlaced_Id)
                .ForeignKey("Supplier.Supplier", t => t.SupplierId, cascadeDelete: true)
                .ForeignKey("Application.User", t => t.UserId)
                .ForeignKey("Application.User", t => t.LastEditedById, cascadeDelete: true)
                .Index(t => t.SupplierId)
                .Index(t => t.UserId)
                .Index(t => t.LastEditedById)
                .Index(t => t.OrdersPlaced_Id);
            
            CreateTable(
                "Sales.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderMethod = c.String(maxLength: 60),
                        OrderDate = c.DateTime(nullable: false),
                        ExpectedPickupDate = c.DateTime(nullable: false),
                        PickingCompletedWhen = c.DateTime(nullable: false),
                        LastEditedWhen = c.DateTime(nullable: false),
                        LastEditedById = c.Int(nullable: false),
                        SalesPersonId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sales.Customers", t => t.CustomerId)
                .ForeignKey("Application.User", t => t.LastEditedById)
                .ForeignKey("Application.User", t => t.SalesPersonId, cascadeDelete: true)
                .Index(t => t.LastEditedById)
                .Index(t => t.SalesPersonId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "Sales.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 60),
                        CustomerBankAccount = c.String(nullable: false, maxLength: 60),
                        CustomerBankName = c.String(nullable: false, maxLength: 60),
                        PhoneNumber = c.String(nullable: false, maxLength: 10),
                        EmailAddress = c.String(nullable: false, maxLength: 60),
                        CustomerAddress = c.String(nullable: false, maxLength: 65),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sales.OrderLines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 100),
                        OrderQuantity = c.Int(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        LastEditedWhen = c.DateTime(nullable: false),
                        LastEditedById = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        AnimalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Warehouse.Animal", t => t.AnimalId, cascadeDelete: true)
                .ForeignKey("Sales.Orders", t => t.OrderId)
                .ForeignKey("Application.User", t => t.LastEditedById, cascadeDelete: true)
                .Index(t => t.LastEditedById)
                .Index(t => t.OrderId)
                .Index(t => t.AnimalId);
            
            CreateTable(
                "Supplier.Supplier",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(nullable: false, maxLength: 60),
                        BankAccountNumber = c.String(nullable: false, maxLength: 60),
                        BankName = c.String(nullable: false, maxLength: 60),
                        PhysicalAddress = c.String(nullable: false, maxLength: 60),
                        PrimaryContactPersonId = c.Int(nullable: false),
                        AlternativeContactPersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Supplier.SupplierContactPerson", t => t.AlternativeContactPersonId)
                .ForeignKey("Supplier.SupplierContactPerson", t => t.PrimaryContactPersonId)
                .Index(t => t.PrimaryContactPersonId)
                .Index(t => t.AlternativeContactPersonId);
            
            CreateTable(
                "Supplier.SupplierContactPerson",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 60),
                        PhoneNumber = c.String(nullable: false),
                        EmailAddress = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sales.AnimalSupplier",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnimalId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Warehouse.Animal", t => t.AnimalId, cascadeDelete: true)
                .ForeignKey("Supplier.Supplier", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.AnimalId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "HR.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        PreferedName = c.String(maxLength: 50),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(nullable: false, maxLength: 35),
                        HiredDate = c.DateTime(nullable: false),
                        TerminationDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Application.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Sales.OrderLines", "LastEditedById", "Application.User");
            DropForeignKey("HR.Employee", "UserId", "Application.User");
            DropForeignKey("Purchasing.PurchaseOrders", "LastEditedById", "Application.User");
            DropForeignKey("Sales.PurchaseOrderLines", "LastEditedById", "Application.User");
            DropForeignKey("Sales.PurchaseOrderLines", "PurchaseOrderId", "Purchasing.PurchaseOrders");
            DropForeignKey("Purchasing.PurchaseOrders", "UserId", "Application.User");
            DropForeignKey("Purchasing.PurchaseOrders", "SupplierId", "Supplier.Supplier");
            DropForeignKey("Supplier.Supplier", "PrimaryContactPersonId", "Supplier.SupplierContactPerson");
            DropForeignKey("Sales.AnimalSupplier", "SupplierId", "Supplier.Supplier");
            DropForeignKey("Sales.AnimalSupplier", "AnimalId", "Warehouse.Animal");
            DropForeignKey("Supplier.Supplier", "AlternativeContactPersonId", "Supplier.SupplierContactPerson");
            DropForeignKey("Purchasing.PurchaseOrders", "OrdersPlaced_Id", "Sales.Orders");
            DropForeignKey("Sales.Orders", "SalesPersonId", "Application.User");
            DropForeignKey("Sales.OrderLines", "OrderId", "Sales.Orders");
            DropForeignKey("Sales.OrderLines", "AnimalId", "Warehouse.Animal");
            DropForeignKey("Sales.Orders", "LastEditedById", "Application.User");
            DropForeignKey("Sales.Orders", "CustomerId", "Sales.Customers");
            DropForeignKey("Sales.PurchaseOrderLines", "AnimalId", "Warehouse.Animal");
            DropForeignKey("Warehouse.AnimalStock", "LastEditedById", "Application.User");
            DropForeignKey("Warehouse.AnimalStock", "AnimalId", "Warehouse.Animal");
            DropIndex("HR.Employee", new[] { "UserId" });
            DropIndex("Sales.AnimalSupplier", new[] { "SupplierId" });
            DropIndex("Sales.AnimalSupplier", new[] { "AnimalId" });
            DropIndex("Supplier.Supplier", new[] { "AlternativeContactPersonId" });
            DropIndex("Supplier.Supplier", new[] { "PrimaryContactPersonId" });
            DropIndex("Sales.OrderLines", new[] { "AnimalId" });
            DropIndex("Sales.OrderLines", new[] { "OrderId" });
            DropIndex("Sales.OrderLines", new[] { "LastEditedById" });
            DropIndex("Sales.Orders", new[] { "CustomerId" });
            DropIndex("Sales.Orders", new[] { "SalesPersonId" });
            DropIndex("Sales.Orders", new[] { "LastEditedById" });
            DropIndex("Purchasing.PurchaseOrders", new[] { "OrdersPlaced_Id" });
            DropIndex("Purchasing.PurchaseOrders", new[] { "LastEditedById" });
            DropIndex("Purchasing.PurchaseOrders", new[] { "UserId" });
            DropIndex("Purchasing.PurchaseOrders", new[] { "SupplierId" });
            DropIndex("Sales.PurchaseOrderLines", new[] { "LastEditedById" });
            DropIndex("Sales.PurchaseOrderLines", new[] { "AnimalId" });
            DropIndex("Sales.PurchaseOrderLines", new[] { "PurchaseOrderId" });
            DropIndex("Warehouse.AnimalStock", new[] { "LastEditedById" });
            DropIndex("Warehouse.AnimalStock", new[] { "AnimalId" });
            DropTable("HR.Employee");
            DropTable("Sales.AnimalSupplier");
            DropTable("Supplier.SupplierContactPerson");
            DropTable("Supplier.Supplier");
            DropTable("Sales.OrderLines");
            DropTable("Sales.Customers");
            DropTable("Sales.Orders");
            DropTable("Purchasing.PurchaseOrders");
            DropTable("Sales.PurchaseOrderLines");
            DropTable("Application.User");
            DropTable("Warehouse.AnimalStock");
            DropTable("Warehouse.Animal");
        }
    }
}
