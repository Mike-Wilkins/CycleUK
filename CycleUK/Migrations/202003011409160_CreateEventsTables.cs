namespace CycleUK.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEventsTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Postcode = c.String(nullable: false, maxLength: 8),
                        Comment = c.String(nullable: false, maxLength: 300),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
