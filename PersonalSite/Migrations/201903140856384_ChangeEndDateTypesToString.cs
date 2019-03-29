namespace PersonalSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeEndDateTypesToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Educations", "EndDate", c => c.String(maxLength: 255));
            AlterColumn("dbo.Expriences", "EndDate", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Expriences", "EndDate", c => c.DateTime());
            AlterColumn("dbo.Educations", "EndDate", c => c.DateTime());
        }
    }
}
