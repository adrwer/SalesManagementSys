namespace SalesManagementSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrdersTable1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "Processed");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Processed");
        }
    }
}
