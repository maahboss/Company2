namespace Company.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFileTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        ImageType = c.String(),
                        Note = c.String(),
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Files", "OrderId", "dbo.Orders");
            DropIndex("dbo.Files", new[] { "OrderId" });
            DropTable("dbo.Files");
        }
    }
}
