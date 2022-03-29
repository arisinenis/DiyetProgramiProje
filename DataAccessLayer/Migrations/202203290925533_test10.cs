namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserInformations", "Gender", c => c.String(nullable: false, maxLength: 6));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserInformations", "Gender", c => c.String(nullable: false, maxLength: 5));
        }
    }
}
