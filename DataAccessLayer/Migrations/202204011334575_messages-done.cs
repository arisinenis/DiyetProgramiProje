namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class messagesdone : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserInformations", "DieticianId", "dbo.Dieticians");
            DropIndex("dbo.UserInformations", new[] { "DieticianId" });
            AlterColumn("dbo.UserInformations", "DieticianId", c => c.Int(nullable: false));
            CreateIndex("dbo.UserInformations", "DieticianId");
            AddForeignKey("dbo.UserInformations", "DieticianId", "dbo.Dieticians", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserInformations", "DieticianId", "dbo.Dieticians");
            DropIndex("dbo.UserInformations", new[] { "DieticianId" });
            AlterColumn("dbo.UserInformations", "DieticianId", c => c.Int());
            CreateIndex("dbo.UserInformations", "DieticianId");
            AddForeignKey("dbo.UserInformations", "DieticianId", "dbo.Dieticians", "Id");
        }
    }
}
