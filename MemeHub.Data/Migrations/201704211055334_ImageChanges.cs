namespace MemeHub.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Memes", "MemeImageUrl", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "ProiflePictureUrl", c => c.String());
            DropColumn("dbo.Memes", "MemeImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Memes", "MemeImage", c => c.Binary(nullable: false));
            DropColumn("dbo.AspNetUsers", "ProiflePictureUrl");
            DropColumn("dbo.Memes", "MemeImageUrl");
        }
    }
}
