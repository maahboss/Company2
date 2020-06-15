namespace Company.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrdersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderNo = c.String(),
                        Year = c.String(),
                        Note = c.String(),
                        ExporterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exporters", t => t.ExporterId, cascadeDelete: true)
                .Index(t => t.ExporterId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ExporterId", "dbo.Exporters");
            DropIndex("dbo.Orders", new[] { "ExporterId" });
            DropTable("dbo.Orders");
        }
    }
}
