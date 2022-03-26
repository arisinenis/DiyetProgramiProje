namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CalorieColumnAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserMealsAndFoods", "Calorie", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.FoodNames", "Calorie", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FoodNames", "Calorie", c => c.Int(nullable: false));
            DropColumn("dbo.UserMealsAndFoods", "Calorie");
        }
    }
}
