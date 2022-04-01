namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MessagesUpdatedAgain : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DieticianMessages", "MessageHeader", c => c.String(nullable: false));
            AlterColumn("dbo.DieticianMessages", "Text", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DieticianMessages", "Text", c => c.String());
            AlterColumn("dbo.DieticianMessages", "MessageHeader", c => c.String());
        }
    }
}
