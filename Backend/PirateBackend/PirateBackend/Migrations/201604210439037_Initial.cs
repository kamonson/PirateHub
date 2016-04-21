namespace PirateBackend.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AthleticEvents",
                c => new
                    {
                        AthleticEventId = c.Int(nullable: false, identity: true),
                        AthleticEventType = c.String(),
                        AthleticEventDescription = c.String(),
                        AthleticEventDateTime = c.DateTime(nullable: false),
                        AthleticEventLocation = c.String(),
                        AthleticEventOpponent = c.String(),
                        Self = c.String(),
                    })
                .PrimaryKey(t => t.AthleticEventId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AthleticEvents");
        }
    }
}
