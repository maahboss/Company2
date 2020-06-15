namespace Company.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExporterTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exporters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Exporters");
        }
    }
}
