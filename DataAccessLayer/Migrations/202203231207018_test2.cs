namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserMeals", "MealTimeId", c => c.Int(nullable: false));
            CreateIndex("dbo.UserMeals", "MealTimeId");
            AddForeignKey("dbo.UserMeals", "MealTimeId", "dbo.MealTimes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserMeals", "MealTimeId", "dbo.MealTimes");
            DropIndex("dbo.UserMeals", new[] { "MealTimeId" });
            DropColumn("dbo.UserMeals", "MealTimeId");
        }
    }
}
