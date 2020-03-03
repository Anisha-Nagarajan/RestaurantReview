namespace RestaurantDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        City = c.Int(nullable: false),
                        PhoneNumber = c.Long(nullable: false),
                        Role = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerFeedbacks",
                c => new
                    {
                        RestaurantName = c.String(nullable: false, maxLength: 128),
                        FoodQuality = c.String(nullable: false),
                        OverallServiceQuality = c.String(nullable: false),
                        Cleanliness = c.String(nullable: false),
                        OrderAccuracy = c.String(nullable: false),
                        SpeedOfService = c.String(nullable: false),
                        Price = c.String(nullable: false),
                        OverallExperience = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RestaurantName);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Restaurants");
            DropTable("dbo.CustomerFeedbacks");
            DropTable("dbo.Customers");
        }
    }
}
