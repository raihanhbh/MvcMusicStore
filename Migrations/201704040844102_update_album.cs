namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_album : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Albums", "Artist_ArtistID", "dbo.Artists");
            DropIndex("dbo.Albums", new[] { "Artist_ArtistID" });
            AddColumn("dbo.Albums", "ArtistID", c => c.Int(nullable: false));
            DropColumn("dbo.Albums", "Artist_ArtistID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Albums", "Artist_ArtistID", c => c.Int());
            DropColumn("dbo.Albums", "ArtistID");
            CreateIndex("dbo.Albums", "Artist_ArtistID");
            AddForeignKey("dbo.Albums", "Artist_ArtistID", "dbo.Artists", "ArtistID");
        }
    }
}
