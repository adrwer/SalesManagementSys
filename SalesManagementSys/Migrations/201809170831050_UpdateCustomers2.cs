namespace SalesManagementSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomers2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DateofBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "DateofBirth", c => c.DateTime(nullable: false));
        }
    }
}
