namespace Company.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExporterNameToFileTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Files", "ExporterName", c => c.String());
            AddColumn("dbo.Files", "exporters_Id", c => c.Int());
            CreateIndex("dbo.Files", "exporters_Id");
            AddForeignKey("dbo.Files", "exporters_Id", "dbo.Exporters", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Files", "exporters_Id", "dbo.Exporters");
            DropIndex("dbo.Files", new[] { "exporters_Id" });
            DropColumn("dbo.Files", "exporters_Id");
            DropColumn("dbo.Files", "ExporterName");
        }
    }
}
