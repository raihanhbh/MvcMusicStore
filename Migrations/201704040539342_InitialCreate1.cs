namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        AlbumID = c.Int(nullable: false),
                        Contents = c.String(),
                        ReviewerEmail = c.String(),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.Albums", t => t.AlbumID, cascadeDelete: true)
                .Index(t => t.AlbumID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "AlbumID", "dbo.Albums");
            DropIndex("dbo.Reviews", new[] { "AlbumID" });
            DropTable("dbo.Reviews");
        }
    }
}
