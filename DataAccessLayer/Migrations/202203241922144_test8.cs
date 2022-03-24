namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserInfosAndMeals", "UserInfoRefId", "dbo.UserInformations");
            DropForeignKey("dbo.UserInfosAndMeals", "UserMealRefId", "dbo.UserMeals");
            DropIndex("dbo.UserInfosAndMeals", new[] { "UserInfoRefId" });
            DropIndex("dbo.UserInfosAndMeals", new[] { "UserMealRefId" });
            AddColumn("dbo.Dieticians", "Status", c => c.String());
            AddColumn("dbo.UserMeals", "UserInformationId", c => c.Int(nullable: false));
            CreateIndex("dbo.UserMeals", "UserInformationId");
            AddForeignKey("dbo.UserMeals", "UserInformationId", "dbo.UserInformations", "Id", cascadeDelete: true);
            DropTable("dbo.UserInfosAndMeals");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserInfosAndMeals",
                c => new
                    {
                        UserInfoRefId = c.Int(nullable: false),
                        UserMealRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserInfoRefId, t.UserMealRefId });
            
            DropForeignKey("dbo.UserMeals", "UserInformationId", "dbo.UserInformations");
            DropIndex("dbo.UserMeals", new[] { "UserInformationId" });
            DropColumn("dbo.UserMeals", "UserInformationId");
            DropColumn("dbo.Dieticians", "Status");
            CreateIndex("dbo.UserInfosAndMeals", "UserMealRefId");
            CreateIndex("dbo.UserInfosAndMeals", "UserInfoRefId");
            AddForeignKey("dbo.UserInfosAndMeals", "UserMealRefId", "dbo.UserMeals", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserInfosAndMeals", "UserInfoRefId", "dbo.UserInformations", "Id", cascadeDelete: true);
        }
    }
}
