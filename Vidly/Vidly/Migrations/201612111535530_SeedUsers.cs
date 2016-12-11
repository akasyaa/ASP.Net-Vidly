namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2a910e53-5f6b-4d84-851c-dde6c97ffbfa', N'guest@vidly.com', 0, N'AO/OaGF2hVJ/XVXUNtxERwtDZAsr21MJEkLaNUUwDJ9XDPkUH2LwB1x0ubkoiYxhcw==', N'f9ebcc2b-9e83-4758-b4a5-029fe124e60e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'debd1b0c-a824-4a14-820b-2132471efa47', N'admin@vidly.com', 0, N'AMLFW8LFfD8Chhi3kokjQ/gd5oEHi3i7mdbgY1K76Mzw2srbj2A/d/iwgzElJs6EqA==', N'77a0b967-918a-4270-90d2-aaa30591bc25', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a43e60b1-0d9a-4260-b922-5c881247fa20', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'debd1b0c-a824-4a14-820b-2132471efa47', N'a43e60b1-0d9a-4260-b922-5c881247fa20')

        
            ");
        }
        
        public override void Down()
        {
        }
    }
}
