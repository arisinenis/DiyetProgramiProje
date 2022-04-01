namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MessagesUpdated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Messages", "DieticianId", "dbo.Dieticians");
            DropIndex("dbo.Messages", new[] { "DieticianId" });
            CreateTable(
                "dbo.DieticianMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        MessageHeader = c.String(),
                        Text = c.String(),
                        Status = c.String(),
                        MessageDate = c.DateTime(nullable: false),
                        DieticianId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dieticians", t => t.DieticianId, cascadeDelete: true)
                .Index(t => t.DieticianId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DieticianMessages", "DieticianId", "dbo.Dieticians");
            DropIndex("dbo.DieticianMessages", new[] { "DieticianId" });
            DropTable("dbo.DieticianMessages");
            CreateIndex("dbo.Messages", "DieticianId");
            AddForeignKey("dbo.Messages", "DieticianId", "dbo.Dieticians", "Id", cascadeDelete: true);
        }
    }
}
