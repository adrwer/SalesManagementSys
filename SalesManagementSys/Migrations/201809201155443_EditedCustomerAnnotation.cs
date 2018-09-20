namespace SalesManagementSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedCustomerAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "CreatedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CreatedOn", c => c.DateTime(nullable: false));
        }
    }
}
