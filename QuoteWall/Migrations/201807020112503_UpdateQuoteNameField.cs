namespace QuoteWall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateQuoteNameField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Quotes", "Title", c => c.String());
            DropColumn("dbo.Quotes", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Quotes", "Name", c => c.String());
            DropColumn("dbo.Quotes", "Title");
        }
    }
}
