namespace QuoteWall.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameFieldsAndDateField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "FirstName", c => c.String());
            AddColumn("dbo.People", "LastName", c => c.String());
            AddColumn("dbo.People", "Nickname", c => c.String());
            AddColumn("dbo.Quotes", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Quotes", "Context", c => c.String());
            DropColumn("dbo.People", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Name", c => c.String());
            DropColumn("dbo.Quotes", "Context");
            DropColumn("dbo.Quotes", "DateCreated");
            DropColumn("dbo.People", "Nickname");
            DropColumn("dbo.People", "LastName");
            DropColumn("dbo.People", "FirstName");
        }
    }
}
