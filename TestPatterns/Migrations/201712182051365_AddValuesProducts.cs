namespace TestPatterns.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValuesProducts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Internal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "Import", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "Manufactory", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Manufactory");
            DropColumn("dbo.Products", "Import");
            DropColumn("dbo.Products", "Internal");
        }
    }
}
