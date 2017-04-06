namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_review_model : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "ReviewerStar", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "ReviewerStar");
        }
    }
}
