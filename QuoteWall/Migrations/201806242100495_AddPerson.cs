namespace QuoteWall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quotes", "Text", c => c.String());
            AddColumn("dbo.Quotes", "Approver_Id", c => c.Int());
            AddColumn("dbo.Quotes", "Author_Id", c => c.Int());
            CreateIndex("dbo.Quotes", "Approver_Id");
            CreateIndex("dbo.Quotes", "Author_Id");
            AddForeignKey("dbo.Quotes", "Approver_Id", "dbo.People", "Id");
            AddForeignKey("dbo.Quotes", "Author_Id", "dbo.People", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Quotes", "Author_Id", "dbo.People");
            DropForeignKey("dbo.Quotes", "Approver_Id", "dbo.People");
            DropIndex("dbo.Quotes", new[] { "Author_Id" });
            DropIndex("dbo.Quotes", new[] { "Approver_Id" });
            DropColumn("dbo.Quotes", "Author_Id");
            DropColumn("dbo.Quotes", "Approver_Id");
            DropColumn("dbo.Quotes", "Text");
        }
    }
}
