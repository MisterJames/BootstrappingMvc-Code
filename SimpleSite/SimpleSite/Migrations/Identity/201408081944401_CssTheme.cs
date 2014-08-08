namespace SimpleSite.Migrations.Identity
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CssTheme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CssTheme", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "CssTheme");
        }
    }
}
