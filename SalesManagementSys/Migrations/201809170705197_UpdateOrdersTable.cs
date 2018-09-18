namespace SalesManagementSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrdersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Processed", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Processed");
        }
    }
}
