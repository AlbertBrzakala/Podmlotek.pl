namespace Podmlotek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addrole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "role", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "role");
        }
    }
}
