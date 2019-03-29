namespace PersonalSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeSocialNetworkNames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "TelegramId", c => c.String(maxLength: 255));
            AddColumn("dbo.People", "TwitterId", c => c.String(maxLength: 255));
            AddColumn("dbo.People", "InstagramId", c => c.String(maxLength: 255));
            AddColumn("dbo.People", "SoroushId", c => c.String(maxLength: 255));
            AddColumn("dbo.People", "LinkedinId", c => c.String(maxLength: 255));
            DropColumn("dbo.People", "TelegramLink");
            DropColumn("dbo.People", "TwitterLink");
            DropColumn("dbo.People", "InstagramLink");
            DropColumn("dbo.People", "SoroushLink");
            DropColumn("dbo.People", "LinkedinLink");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "LinkedinLink", c => c.String(maxLength: 255));
            AddColumn("dbo.People", "SoroushLink", c => c.String(maxLength: 255));
            AddColumn("dbo.People", "InstagramLink", c => c.String(maxLength: 255));
            AddColumn("dbo.People", "TwitterLink", c => c.String(maxLength: 255));
            AddColumn("dbo.People", "TelegramLink", c => c.String(maxLength: 255));
            DropColumn("dbo.People", "LinkedinId");
            DropColumn("dbo.People", "SoroushId");
            DropColumn("dbo.People", "InstagramId");
            DropColumn("dbo.People", "TwitterId");
            DropColumn("dbo.People", "TelegramId");
        }
    }
}
