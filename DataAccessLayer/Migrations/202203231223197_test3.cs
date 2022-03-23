namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserMeals", "MealTimeId", "dbo.MealTimes");
            DropIndex("dbo.UserMeals", new[] { "MealTimeId" });
            AddColumn("dbo.UserMeals", "MealTime", c => c.Int(nullable: false));
            DropColumn("dbo.UserMeals", "MealTimeId");
            DropTable("dbo.MealTimes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MealTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.UserMeals", "MealTimeId", c => c.Int(nullable: false));
            DropColumn("dbo.UserMeals", "MealTime");
            CreateIndex("dbo.UserMeals", "MealTimeId");
            AddForeignKey("dbo.UserMeals", "MealTimeId", "dbo.MealTimes", "Id", cascadeDelete: true);
        }
    }
}
