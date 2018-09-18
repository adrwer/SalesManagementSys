namespace SalesManagementSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "FirstName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "Sex", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "Address", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "State", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "Street", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "MobileNo", c => c.String(maxLength: 15));
            AlterColumn("dbo.Customers", "PhoneNo", c => c.String(maxLength: 15));
            AlterColumn("dbo.Products", "ProductName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Products", "ProductDescription", c => c.String(maxLength: 255));
            AlterColumn("dbo.ProductCategories", "Category", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductCategories", "Category", c => c.String());
            AlterColumn("dbo.Products", "ProductDescription", c => c.String());
            AlterColumn("dbo.Products", "ProductName", c => c.String());
            AlterColumn("dbo.Customers", "PhoneNo", c => c.String());
            AlterColumn("dbo.Customers", "MobileNo", c => c.String());
            AlterColumn("dbo.Customers", "Street", c => c.String());
            AlterColumn("dbo.Customers", "State", c => c.String());
            AlterColumn("dbo.Customers", "Address", c => c.String());
            AlterColumn("dbo.Customers", "Sex", c => c.String());
            AlterColumn("dbo.Customers", "LastName", c => c.String());
            AlterColumn("dbo.Customers", "FirstName", c => c.String());
        }
    }
}
