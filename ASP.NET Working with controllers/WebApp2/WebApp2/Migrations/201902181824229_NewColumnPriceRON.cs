namespace WebApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewColumnPriceRON : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "PriceInRON", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "PriceInRON");
        }
    }
}
