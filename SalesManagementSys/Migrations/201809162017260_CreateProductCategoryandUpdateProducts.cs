namespace SalesManagementSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateProductCategoryandUpdateProducts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ProductCategoryID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProductCategoryID);
            
            AddColumn("dbo.Products", "ProductCategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "ProductCategoryID");
            AddForeignKey("dbo.Products", "ProductCategoryID", "dbo.ProductCategories", "ProductCategoryID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductCategoryID", "dbo.ProductCategories");
            DropIndex("dbo.Products", new[] { "ProductCategoryID" });
            DropColumn("dbo.Products", "ProductCategoryID");
            DropTable("dbo.ProductCategories");
        }
    }
}
