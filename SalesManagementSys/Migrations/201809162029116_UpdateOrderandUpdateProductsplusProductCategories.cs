namespace SalesManagementSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrderandUpdateProductsplusProductCategories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        OrderTotal = c.Int(nullable: false),
                        UnitPrice = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.Orders", new[] { "ProductID" });
            DropTable("dbo.Orders");
        }
    }
}
