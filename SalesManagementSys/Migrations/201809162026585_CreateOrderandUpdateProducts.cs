namespace SalesManagementSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOrderandUpdateProducts : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "UnitPrice", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "UnitPrice", c => c.String());
        }
    }
}
