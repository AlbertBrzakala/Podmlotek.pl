﻿namespace Podmlotek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteUnnecessaryProperties : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "CategoriesId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "CategoriesId", c => c.Int(nullable: false));
        }
    }
}
