namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2d7dce60-fe05-44f2-aca0-a2ba409124e7', N'guest@Vidly.com', 0, N'ALzmXIKsW/OApGMo6ZWkMXYCOgex/nHuNE4evEsaMtq92P3Aw3yOa9Ev+ECv7zTcAQ==', N'ef6e3b39-edc3-4642-99a2-d76afa938601', NULL, 0, 0, NULL, 1, 0, N'guest@Vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e1e3a266-c193-48df-81e8-3aecc55b9dc0', N'admin@vidly.com', 0, N'AGCJd7/e5eYTqK7b+QvVz7K+2X6pjexjsUsvh3RwkwP+T+YHdq+Ar3mSAmygF/0qyQ==', N'a357cf38-7e58-4991-9da5-2ca12b420422', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5ef836ab-32c4-4e17-85f3-266ce80ee9ba', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e1e3a266-c193-48df-81e8-3aecc55b9dc0', N'5ef836ab-32c4-4e17-85f3-266ce80ee9ba')

");
        }
        
        public override void Down()
        {
        }
    }
}
