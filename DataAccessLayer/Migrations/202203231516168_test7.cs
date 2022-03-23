namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserRegisterInfoes", "UserInformationId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserRegisterInfoes", "UserInformationId");
        }
    }
}
