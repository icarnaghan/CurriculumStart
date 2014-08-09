namespace Mapper21.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DomainChanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BigIdeas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Name = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BigIdeas");
        }
    }
}
