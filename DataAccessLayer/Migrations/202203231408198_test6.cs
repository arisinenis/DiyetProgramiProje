namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test6 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserInformations", "UserRegisterInfoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserInformations", "UserRegisterInfoId", c => c.Int(nullable: false));
        }
    }
}
