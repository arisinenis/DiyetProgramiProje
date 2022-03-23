namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DieticianRegisterInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        UserType = c.Int(nullable: false),
                        DieticianId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dieticians", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Dieticians",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Graduation = c.String(nullable: false, maxLength: 100),
                        Picture = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        BirthDate = c.DateTime(nullable: false),
                        Gender = c.String(nullable: false, maxLength: 5),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserRequest = c.Int(nullable: false),
                        Status = c.String(nullable: false, maxLength: 7),
                        DieticianId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dieticians", t => t.DieticianId, cascadeDelete: true)
                .Index(t => t.DieticianId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MessageHeader = c.String(nullable: false),
                        Text = c.String(nullable: false),
                        UserInformationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserInformations", t => t.UserInformationId, cascadeDelete: true)
                .Index(t => t.UserInformationId);
            
            CreateTable(
                "dbo.UserMeals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MealDate = c.DateTime(nullable: false),
                        Portion = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FoodNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Calorie = c.Int(nullable: false),
                        Status = c.String(nullable: false, maxLength: 8),
                        FoodCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FoodCategories", t => t.FoodCategoryId, cascadeDelete: true)
                .Index(t => t.Name, unique: true)
                .Index(t => t.FoodCategoryId);
            
            CreateTable(
                "dbo.FoodCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRegisterInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 20),
                        UserType = c.Int(nullable: false),
                        UserInformationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserInformations", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.MealTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserMealsAndFoodNames",
                c => new
                    {
                        UserMealRefId = c.Int(nullable: false),
                        FoodNameRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserMealRefId, t.FoodNameRefId })
                .ForeignKey("dbo.FoodNames", t => t.UserMealRefId, cascadeDelete: true)
                .ForeignKey("dbo.UserMeals", t => t.FoodNameRefId, cascadeDelete: true)
                .Index(t => t.UserMealRefId)
                .Index(t => t.FoodNameRefId);
            
            CreateTable(
                "dbo.UserInfosAndMeals",
                c => new
                    {
                        UserInfoRefId = c.Int(nullable: false),
                        UserMealRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserInfoRefId, t.UserMealRefId })
                .ForeignKey("dbo.UserInformations", t => t.UserInfoRefId, cascadeDelete: true)
                .ForeignKey("dbo.UserMeals", t => t.UserMealRefId, cascadeDelete: true)
                .Index(t => t.UserInfoRefId)
                .Index(t => t.UserMealRefId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInformations", "DieticianId", "dbo.Dieticians");
            DropForeignKey("dbo.UserRegisterInfoes", "Id", "dbo.UserInformations");
            DropForeignKey("dbo.UserInfosAndMeals", "UserMealRefId", "dbo.UserMeals");
            DropForeignKey("dbo.UserInfosAndMeals", "UserInfoRefId", "dbo.UserInformations");
            DropForeignKey("dbo.UserMealsAndFoodNames", "FoodNameRefId", "dbo.UserMeals");
            DropForeignKey("dbo.UserMealsAndFoodNames", "UserMealRefId", "dbo.FoodNames");
            DropForeignKey("dbo.FoodNames", "FoodCategoryId", "dbo.FoodCategories");
            DropForeignKey("dbo.Messages", "UserInformationId", "dbo.UserInformations");
            DropForeignKey("dbo.DieticianRegisterInfoes", "Id", "dbo.Dieticians");
            DropIndex("dbo.UserInfosAndMeals", new[] { "UserMealRefId" });
            DropIndex("dbo.UserInfosAndMeals", new[] { "UserInfoRefId" });
            DropIndex("dbo.UserMealsAndFoodNames", new[] { "FoodNameRefId" });
            DropIndex("dbo.UserMealsAndFoodNames", new[] { "UserMealRefId" });
            DropIndex("dbo.UserRegisterInfoes", new[] { "Id" });
            DropIndex("dbo.FoodNames", new[] { "FoodCategoryId" });
            DropIndex("dbo.FoodNames", new[] { "Name" });
            DropIndex("dbo.Messages", new[] { "UserInformationId" });
            DropIndex("dbo.UserInformations", new[] { "DieticianId" });
            DropIndex("dbo.DieticianRegisterInfoes", new[] { "Id" });
            DropTable("dbo.UserInfosAndMeals");
            DropTable("dbo.UserMealsAndFoodNames");
            DropTable("dbo.MealTimes");
            DropTable("dbo.UserRegisterInfoes");
            DropTable("dbo.FoodCategories");
            DropTable("dbo.FoodNames");
            DropTable("dbo.UserMeals");
            DropTable("dbo.Messages");
            DropTable("dbo.UserInformations");
            DropTable("dbo.Dieticians");
            DropTable("dbo.DieticianRegisterInfoes");
        }
    }
}
