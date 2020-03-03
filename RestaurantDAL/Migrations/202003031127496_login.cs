namespace RestaurantDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class login : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "City", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "City", c => c.Int(nullable: false));
        }
    }
}
