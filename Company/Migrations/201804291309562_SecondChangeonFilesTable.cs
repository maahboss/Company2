namespace Company.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondChangeonFilesTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Files", "ExporterName", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Files", "ExporterName", c => c.String());
        }
    }
}
