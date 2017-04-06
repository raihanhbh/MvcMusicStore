namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        AlbumID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ReleaseYear = c.String(),
                        Artist_ArtistID = c.Int(),
                    })
                .PrimaryKey(t => t.AlbumID)
                .ForeignKey("dbo.Artists", t => t.Artist_ArtistID)
                .Index(t => t.Artist_ArtistID);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Album_AlbumID = c.Int(),
                    })
                .PrimaryKey(t => t.ArtistID)
                .ForeignKey("dbo.Albums", t => t.Album_AlbumID)
                .Index(t => t.Album_AlbumID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Artists", "Album_AlbumID", "dbo.Albums");
            DropForeignKey("dbo.Albums", "Artist_ArtistID", "dbo.Artists");
            DropIndex("dbo.Artists", new[] { "Album_AlbumID" });
            DropIndex("dbo.Albums", new[] { "Artist_ArtistID" });
            DropTable("dbo.Artists");
            DropTable("dbo.Albums");
        }
    }
}
