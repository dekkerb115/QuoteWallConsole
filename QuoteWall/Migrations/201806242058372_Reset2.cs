namespace QuoteWall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reset2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Quotes", "Approver_Id", "dbo.People");
            DropForeignKey("dbo.Quotes", "Author_Id", "dbo.People");
            DropIndex("dbo.Quotes", new[] { "Approver_Id" });
            DropIndex("dbo.Quotes", new[] { "Author_Id" });
            //DropColumn("dbo.Quotes", "Text");
            //DropColumn("dbo.Quotes", "Approver_Id");
            //DropColumn("dbo.Quotes", "Author_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Quotes", "Author_Id", c => c.Int());
            AddColumn("dbo.Quotes", "Approver_Id", c => c.Int());
            AddColumn("dbo.Quotes", "Text", c => c.String());
            CreateIndex("dbo.Quotes", "Author_Id");
            CreateIndex("dbo.Quotes", "Approver_Id");
            AddForeignKey("dbo.Quotes", "Author_Id", "dbo.People", "Id");
            AddForeignKey("dbo.Quotes", "Approver_Id", "dbo.People", "Id");
        }
    }
}
