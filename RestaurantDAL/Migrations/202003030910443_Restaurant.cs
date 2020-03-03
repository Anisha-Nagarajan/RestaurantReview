namespace RestaurantDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Restaurant : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "ConfirmPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "ConfirmPassword", c => c.String(nullable: false));
        }
    }
}
