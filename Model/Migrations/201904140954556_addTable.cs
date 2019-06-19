namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTable : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Category", "CategoryID", c => c.Long());
            //AddColumn("dbo.Category", "Warranty", c => c.Int());
            AlterColumn("dbo.Category", "Name", c => c.String(maxLength: 250));
            AlterColumn("dbo.Category", "Code", c => c.String(maxLength: 10, unicode: false));
            AlterColumn("dbo.Category", "MoreImages", c => c.String(storeType: "xml"));
            AlterColumn("dbo.Category", "Price", c => c.Decimal(precision: 18, scale: 0));
            AlterColumn("dbo.Category", "PromotionPrice", c => c.Decimal(precision: 18, scale: 0));
            AlterColumn("dbo.Category", "IncludedVAT", c => c.Boolean());
            AlterColumn("dbo.Category", "Quantity", c => c.Int());
            AlterColumn("dbo.Category", "Detail", c => c.String(storeType: "ntext"));
            AlterColumn("dbo.Category", "Status", c => c.Boolean());
            AlterColumn("dbo.Content", "Status", c => c.Boolean());
            AlterColumn("dbo.Feedback", "Content", c => c.String(maxLength: 500));
            AlterColumn("dbo.Product", "Quantity", c => c.Int());
            //DropColumn("dbo.Category", "CatetgoryParentID");
            DropColumn("dbo.Category", "SeoTitle");
            DropColumn("dbo.Category", "ShowOnHome");
            DropColumn("dbo.Content", "Language");
            DropTable("dbo.sysdiagrams");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            AddColumn("dbo.Content", "Language", c => c.String());
            AddColumn("dbo.Category", "ShowOnHome", c => c.Boolean());
            AddColumn("dbo.Category", "SeoTitle", c => c.String(maxLength: 250));
            AddColumn("dbo.Category", "CatetgoryParentID", c => c.Long());
            AlterColumn("dbo.Product", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.Feedback", "Content", c => c.String(maxLength: 250));
            AlterColumn("dbo.Content", "Status", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Category", "Status", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Category", "Detail", c => c.String());
            AlterColumn("dbo.Category", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.Category", "IncludedVAT", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Category", "PromotionPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Category", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Category", "MoreImages", c => c.String());
            AlterColumn("dbo.Category", "Code", c => c.String(maxLength: 10));
            AlterColumn("dbo.Category", "Name", c => c.String(nullable: false, maxLength: 250));
            DropColumn("dbo.Category", "Warranty");
            DropColumn("dbo.Category", "CategoryID");
        }
    }
}
