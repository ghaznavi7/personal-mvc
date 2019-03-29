namespace PersonalSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveStartDateColumns : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Educations", "StartDate");
            DropColumn("dbo.Expriences", "StartDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Expriences", "StartDate", c => c.DateTime());
            AddColumn("dbo.Educations", "StartDate", c => c.DateTime());
        }
    }
}
