namespace PersonalSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DefineAdmin : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7d3e7e1e-ffec-479b-9992-bcc3737339e4', N'ghaznavipc@gmail.com', 0, N'AJO7Bn5Bkhc8vk4K8WNqC5uapxzfCDkyACDOQBRY0csAYKwh1hx+ZaT99/kjWHpmoA==', N'c81cb050-b3c6-410c-bc2a-e1d945c40f62', NULL, 0, 0, NULL, 1, 0, N'ghaznavipc@gmail.com')
");
        }

        public override void Down()
        {
            Sql(@"
DELETE FROM [dbo].[AspNetUsers]
");
        }
    }
}
