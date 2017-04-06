namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_review : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Albums", "ReleaseYear", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Albums", "ReleaseYear", c => c.String());
        }
    }
}
