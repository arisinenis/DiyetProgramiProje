namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test9 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserMealsAndFoodNames", "UserMealRefId", "dbo.FoodNames");
            DropForeignKey("dbo.UserMealsAndFoodNames", "FoodNameRefId", "dbo.UserMeals");
            DropIndex("dbo.UserMealsAndFoodNames", new[] { "UserMealRefId" });
            DropIndex("dbo.UserMealsAndFoodNames", new[] { "FoodNameRefId" });
            CreateTable(
                "dbo.UserMealsAndFoods",
                c => new
                    {
                        UserMealID = c.Int(nullable: false),
                        FoodNameID = c.Int(nullable: false),
                        Portion = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.UserMealID, t.FoodNameID })
                .ForeignKey("dbo.FoodNames", t => t.FoodNameID, cascadeDelete: true)
                .ForeignKey("dbo.UserMeals", t => t.UserMealID, cascadeDelete: true)
                .Index(t => t.UserMealID)
                .Index(t => t.FoodNameID);
            
            DropColumn("dbo.UserMeals", "Portion");
            DropTable("dbo.UserMealsAndFoodNames");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserMealsAndFoodNames",
                c => new
                    {
                        UserMealRefId = c.Int(nullable: false),
                        FoodNameRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserMealRefId, t.FoodNameRefId });
            
            AddColumn("dbo.UserMeals", "Portion", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropForeignKey("dbo.UserMealsAndFoods", "UserMealID", "dbo.UserMeals");
            DropForeignKey("dbo.UserMealsAndFoods", "FoodNameID", "dbo.FoodNames");
            DropIndex("dbo.UserMealsAndFoods", new[] { "FoodNameID" });
            DropIndex("dbo.UserMealsAndFoods", new[] { "UserMealID" });
            DropTable("dbo.UserMealsAndFoods");
            CreateIndex("dbo.UserMealsAndFoodNames", "FoodNameRefId");
            CreateIndex("dbo.UserMealsAndFoodNames", "UserMealRefId");
            AddForeignKey("dbo.UserMealsAndFoodNames", "FoodNameRefId", "dbo.UserMeals", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserMealsAndFoodNames", "UserMealRefId", "dbo.FoodNames", "Id", cascadeDelete: true);
        }
    }
}
