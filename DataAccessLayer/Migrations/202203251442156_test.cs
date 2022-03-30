﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DieticianRegisterInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        UserType = c.Int(nullable: false),
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
                        Status = c.String(),
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
                        DailyExercise = c.Int(nullable: false),
                        DailyCalorie = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RequireCalorie = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.String(nullable: false, maxLength: 7),
                        DieticianId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dieticians", t => t.DieticianId)
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
                        MealTime = c.Int(nullable: false),
                        UserInformationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserInformations", t => t.UserInformationId, cascadeDelete: true)
                .Index(t => t.UserInformationId);
            
            CreateTable(
                "dbo.UserMealsAndFoods",
                c => new
                    {
                        UserMealID = c.Int(nullable: false),
                        FoodNameID = c.Int(nullable: false),
                        Portion = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Calorie = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.UserMealID, t.FoodNameID })
                .ForeignKey("dbo.FoodNames", t => t.FoodNameID, cascadeDelete: true)
                .ForeignKey("dbo.UserMeals", t => t.UserMealID, cascadeDelete: true)
                .Index(t => t.UserMealID)
                .Index(t => t.FoodNameID);
            
            CreateTable(
                "dbo.FoodNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Calorie = c.Decimal(nullable: false, precision: 18, scale: 2),
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserInformations", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInformations", "DieticianId", "dbo.Dieticians");
            DropForeignKey("dbo.UserRegisterInfoes", "Id", "dbo.UserInformations");
            DropForeignKey("dbo.UserMeals", "UserInformationId", "dbo.UserInformations");
            DropForeignKey("dbo.UserMealsAndFoods", "UserMealID", "dbo.UserMeals");
            DropForeignKey("dbo.UserMealsAndFoods", "FoodNameID", "dbo.FoodNames");
            DropForeignKey("dbo.FoodNames", "FoodCategoryId", "dbo.FoodCategories");
            DropForeignKey("dbo.Messages", "UserInformationId", "dbo.UserInformations");
            DropForeignKey("dbo.DieticianRegisterInfoes", "Id", "dbo.Dieticians");
            DropIndex("dbo.UserRegisterInfoes", new[] { "Id" });
            DropIndex("dbo.FoodNames", new[] { "FoodCategoryId" });
            DropIndex("dbo.FoodNames", new[] { "Name" });
            DropIndex("dbo.UserMealsAndFoods", new[] { "FoodNameID" });
            DropIndex("dbo.UserMealsAndFoods", new[] { "UserMealID" });
            DropIndex("dbo.UserMeals", new[] { "UserInformationId" });
            DropIndex("dbo.Messages", new[] { "UserInformationId" });
            DropIndex("dbo.UserInformations", new[] { "DieticianId" });
            DropIndex("dbo.DieticianRegisterInfoes", new[] { "Id" });
            DropTable("dbo.UserRegisterInfoes");
            DropTable("dbo.FoodCategories");
            DropTable("dbo.FoodNames");
            DropTable("dbo.UserMealsAndFoods");
            DropTable("dbo.UserMeals");
            DropTable("dbo.Messages");
            DropTable("dbo.UserInformations");
            DropTable("dbo.Dieticians");
            DropTable("dbo.DieticianRegisterInfoes");
        }
    }
}