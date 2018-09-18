namespace SalesManagementSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "CreatedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "CreatedOn", c => c.DateTime(nullable: false));
        }
    }
}
