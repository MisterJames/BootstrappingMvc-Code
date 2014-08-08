namespace SimpleSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonalNotifications : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifications", "UserId", c => c.String());
            AddColumn("dbo.Notifications", "IsDismissed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notifications", "IsDismissed");
            DropColumn("dbo.Notifications", "UserId");
        }
    }
}
