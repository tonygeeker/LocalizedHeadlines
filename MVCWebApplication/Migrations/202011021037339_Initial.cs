namespace MVCWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Article",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        Source = c.String(),
                        Author = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        Url = c.String(),
                        UrlToImage = c.String(),
                        PlublishDate = c.String(),
                        Content = c.String(),
                        User_UserLockoutEnabledByDefault = c.Boolean(nullable: false),
                        User_MaxFailedAccessAttemptsBeforeLockout = c.Int(nullable: false),
                        User_DefaultAccountLockoutTimeSpan = c.Time(nullable: false, precision: 7),
                        UserInput_UserInputId = c.Int(),
                    })
                .PrimaryKey(t => t.ArticleId)
                .ForeignKey("dbo.UserInput", t => t.UserInput_UserInputId)
                .Index(t => t.UserInput_UserInputId);
            
            CreateTable(
                "dbo.UserInput",
                c => new
                    {
                        UserInputId = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        ApplicationUser_UserLockoutEnabledByDefault = c.Boolean(nullable: false),
                        ApplicationUser_MaxFailedAccessAttemptsBeforeLockout = c.Int(nullable: false),
                        ApplicationUser_DefaultAccountLockoutTimeSpan = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.UserInputId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Article", "UserInput_UserInputId", "dbo.UserInput");
            DropIndex("dbo.Article", new[] { "UserInput_UserInputId" });
            DropTable("dbo.UserInput");
            DropTable("dbo.Article");
        }
    }
}
