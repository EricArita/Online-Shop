namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "CatetgoryParentID", c => c.Long());
            AlterColumn("dbo.Category", "Name", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Category", "MoreImages", c => c.String());
            AlterColumn("dbo.Category", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AlterColumn("dbo.Category", "PromotionPrice", c => c.Decimal(nullable: false, precision: 18, scale: 0));
            AlterColumn("dbo.Category", "IncludedVAT", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Category", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.Category", "Detail", c => c.String());
            AlterColumn("dbo.Category", "Status", c => c.Boolean(nullable: false));
            DropColumn("dbo.Category", "ParentCategoryID");
            DropColumn("dbo.Category", "Warranty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Category", "Warranty", c => c.Int());
            AddColumn("dbo.Category", "ParentCategoryID", c => c.Long());
            AlterColumn("dbo.Category", "Status", c => c.Boolean());
            AlterColumn("dbo.Category", "Detail", c => c.String(storeType: "ntext"));
            AlterColumn("dbo.Category", "Quantity", c => c.Int());
            AlterColumn("dbo.Category", "IncludedVAT", c => c.Boolean());
            AlterColumn("dbo.Category", "PromotionPrice", c => c.Decimal(precision: 18, scale: 0));
            AlterColumn("dbo.Category", "Price", c => c.Decimal(precision: 18, scale: 0));
            AlterColumn("dbo.Category", "MoreImages", c => c.String(storeType: "xml"));
            AlterColumn("dbo.Category", "Name", c => c.String(maxLength: 250));
            DropColumn("dbo.Category", "CatetgoryParentID");
        }
    }
}
