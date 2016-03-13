namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Holder", c => c.String());
            DropColumn("dbo.Books", "IsAvailable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "IsAvailable", c => c.Boolean(nullable: false));
            DropColumn("dbo.Books", "Holder");
        }
    }
}
