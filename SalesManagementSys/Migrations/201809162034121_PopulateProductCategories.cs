namespace SalesManagementSys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateProductCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ProductCategories (Category, CreatedOn) VALUES ( 'Cutlery', GETDATE())");
            Sql("INSERT INTO ProductCategories (Category, CreatedOn) VALUES ( 'Stationery', GETDATE())");
            Sql("INSERT INTO ProductCategories (Category, CreatedOn) VALUES ( 'Toiletries', GETDATE())");
        }
        
        public override void Down()
        {
        }
    }
}
