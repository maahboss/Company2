namespace Company.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNoteToExport : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Exporters", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Exporters", "Note");
        }
    }
}
