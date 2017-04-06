namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_band : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bands",
                c => new
                    {
                        BandID = c.Int(nullable: false, identity: true),
                        BandName = c.String(),
                    })
                .PrimaryKey(t => t.BandID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bands");
        }
    }
}
