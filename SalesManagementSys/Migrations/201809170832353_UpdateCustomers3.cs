namespace SalesManagementSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomers3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DateofBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Customers", "CreatedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CreatedOn", c => c.DateTime());
            AlterColumn("dbo.Customers", "DateofBirth", c => c.DateTime());
        }
    }
}
