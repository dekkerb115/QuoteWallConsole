namespace QuoteWall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            /*
            CreateTable(
                "dbo.Quotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Text = c.String(),
                        Approver_Id = c.Int(),
                        Author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Approver_Id)
                .ForeignKey("dbo.People", t => t.Author_Id)
                .Index(t => t.Approver_Id)
                .Index(t => t.Author_Id);
            */
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Quotes", "Author_Id", "dbo.People");
            DropForeignKey("dbo.Quotes", "Approver_Id", "dbo.People");
            DropIndex("dbo.Quotes", new[] { "Author_Id" });
            DropIndex("dbo.Quotes", new[] { "Approver_Id" });
            DropTable("dbo.Quotes");
            DropTable("dbo.People");
        }
    }
}
