namespace S00160641Rad2017MVC1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateJoined : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "dateJoined", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "dateJoined");
        }
    }
}