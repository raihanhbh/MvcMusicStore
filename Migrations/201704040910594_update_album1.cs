namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_album1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Artists", "Album_AlbumID", "dbo.Albums");
            DropIndex("dbo.Artists", new[] { "Album_AlbumID" });
            AddColumn("dbo.Albums", "Artist_ArtistID", c => c.Int());
            CreateIndex("dbo.Albums", "Artist_ArtistID");
            AddForeignKey("dbo.Albums", "Artist_ArtistID", "dbo.Artists", "ArtistID");
            DropColumn("dbo.Albums", "ArtistID");
            DropColumn("dbo.Artists", "Album_AlbumID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Artists", "Album_AlbumID", c => c.Int());
            AddColumn("dbo.Albums", "ArtistID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Albums", "Artist_ArtistID", "dbo.Artists");
            DropIndex("dbo.Albums", new[] { "Artist_ArtistID" });
            DropColumn("dbo.Albums", "Artist_ArtistID");
            CreateIndex("dbo.Artists", "Album_AlbumID");
            AddForeignKey("dbo.Artists", "Album_AlbumID", "dbo.Albums", "AlbumID");
        }
    }
}
