namespace TestPatterns.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "Bonus", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "Tax", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "CategoryId");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.ProductCategories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.ProductCategories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropColumn("dbo.Products", "CategoryId");
            DropColumn("dbo.Products", "Tax");
            DropColumn("dbo.Products", "Bonus");
            DropTable("dbo.ProductCategories");
        }
    }
}
