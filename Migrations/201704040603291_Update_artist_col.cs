namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_artist_col : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Artists", "FirstName", c => c.String());
            AddColumn("dbo.Artists", "LastName", c => c.String());
            DropColumn("dbo.Artists", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Artists", "Name", c => c.String());
            DropColumn("dbo.Artists", "LastName");
            DropColumn("dbo.Artists", "FirstName");
        }
    }
}
