namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserInformations", "DailyExercise", c => c.Int(nullable: false));
            AddColumn("dbo.UserInformations", "DailyCalorie", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.UserInformations", "RequireCalorie", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserInformations", "RequireCalorie");
            DropColumn("dbo.UserInformations", "DailyCalorie");
            DropColumn("dbo.UserInformations", "DailyExercise");
        }
    }
}
