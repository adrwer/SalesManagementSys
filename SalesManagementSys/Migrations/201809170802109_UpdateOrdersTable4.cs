namespace SalesManagementSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrdersTable4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Process", c => c.Boolean(nullable: false));
    
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Process");
        }
    }
}
