namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MessagesUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "MessageDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Messages", "DieticianId", c => c.Int(nullable: false));
            CreateIndex("dbo.Messages", "DieticianId");
            AddForeignKey("dbo.Messages", "DieticianId", "dbo.Dieticians", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "DieticianId", "dbo.Dieticians");
            DropIndex("dbo.Messages", new[] { "DieticianId" });
            DropColumn("dbo.Messages", "DieticianId");
            DropColumn("dbo.Messages", "MessageDate");
        }
    }
}
