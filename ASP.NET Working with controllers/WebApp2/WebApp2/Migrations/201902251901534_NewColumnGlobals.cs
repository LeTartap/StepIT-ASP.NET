namespace WebApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewColumnGlobals : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                            "dbo.Globals",
                            c => new
                            {
                                ID = c.Int(nullable: false, identity: true),
                                eurToRON = c.Single(nullable: false),
                                eurToUSD = c.Single(nullable: false),
                            })
                            .PrimaryKey(t => t.ID);
        }
        
        public override void Down()
        {        
            DropTable("dbo.Globals");
        }
    }
}
