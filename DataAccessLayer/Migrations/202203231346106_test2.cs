namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserRegisterInfoes", "UserInformationId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserRegisterInfoes", "UserInformationId", c => c.Int(nullable: false));
        }
    }
}
