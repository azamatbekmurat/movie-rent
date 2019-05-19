namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2817f9b9-feb9-4f63-b37c-0455bc99b087', N'admin@gmail.com', 0, N'AIXuLCqU9kgSvJsJ+soWPmZ+L/5UGcqYBtPlJt3CpDEooUQp277iVFooOGVLO6ANWQ==', N'76092d95-9551-45c4-9ed0-ec306d8719ca', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e181d236-af20-45a3-a935-04726eb0a14c', N'test@gmail.com', 0, N'AMsnDJGDjDjCwxzvWpDTBAStbJPVClcz2/Dgg9dcztFoJtwDOqOE+qFEfSvRCAZNuQ==', N'8e223a21-a17c-430b-ba8d-9cdd3d67f787', NULL, 0, 0, NULL, 1, 0, N'test@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5e63be7a-a03c-4c07-846c-1d283fd9aed5', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2817f9b9-feb9-4f63-b37c-0455bc99b087', N'5e63be7a-a03c-4c07-846c-1d283fd9aed5')

");
        }
        
        public override void Down()
        {
        }
    }
}
