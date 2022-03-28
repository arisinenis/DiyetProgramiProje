namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dEmailSizeChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "Status", c => c.String());
            AlterColumn("dbo.DieticianRegisterInfoes", "Email", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.DieticianRegisterInfoes", "Email", unique: true);
            CreateIndex("dbo.UserRegisterInfoes", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.UserRegisterInfoes", new[] { "Email" });
            DropIndex("dbo.DieticianRegisterInfoes", new[] { "Email" });
            AlterColumn("dbo.DieticianRegisterInfoes", "Email", c => c.String(nullable: false));
            DropColumn("dbo.Messages", "Status");
        }
    }
}
