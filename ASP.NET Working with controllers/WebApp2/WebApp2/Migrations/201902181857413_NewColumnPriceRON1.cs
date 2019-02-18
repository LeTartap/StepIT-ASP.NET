namespace WebApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewColumnPriceRON1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String());
        }
    }
}
