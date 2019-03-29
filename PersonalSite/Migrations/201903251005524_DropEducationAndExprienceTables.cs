namespace PersonalSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropEducationAndExprienceTables : DbMigration
    {
        public override void Up()
        {
            // because of id bug: id cannot increase
            DropTable("dbo.Educations");
            DropTable("dbo.Expriences");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Expriences",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Position = c.String(nullable: false, maxLength: 255),
                        Location = c.String(maxLength: 255),
                        Description = c.String(),
                        EndDate = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        EarnedCertificate = c.String(nullable: false, maxLength: 255),
                        Location = c.String(nullable: false, maxLength: 255),
                        Description = c.String(),
                        EndDate = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
