namespace PersonalSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEducationAndExprienceTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EarnedCertificate = c.String(nullable: false, maxLength: 255),
                        Location = c.String(nullable: false, maxLength: 255),
                        Description = c.String(),
                        EndDate = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Expriences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position = c.String(nullable: false, maxLength: 255),
                        Location = c.String(maxLength: 255),
                        Description = c.String(),
                        EndDate = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Expriences");
            DropTable("dbo.Educations");
        }
    }
}
