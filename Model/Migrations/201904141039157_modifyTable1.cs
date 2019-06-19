namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "ShowOnHome", c => c.Boolean());
            AddColumn("dbo.Category", "SeoTitle", c => c.String(maxLength: 250));
            DropColumn("dbo.Category", "CategoryID");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Category", "SeoTitle");
            DropColumn("dbo.Category", "ShowOnHome");
        }
    }
}
