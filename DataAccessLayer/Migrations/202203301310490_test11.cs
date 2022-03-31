namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FoodNames", "FoodPicture", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FoodNames", "FoodPicture");
        }
    }
}
