namespace PersonalSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DefineAnEmptyUser : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[People] DEFAULT VALUES");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM [dbo].[People]");
        }
    }
}
