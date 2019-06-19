namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "ShowOnHome", c => c.Boolean());
            AddColumn("dbo.Category", "SeoTitle", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {     
            DropColumn("dbo.Category", "CategoryID");
        }
    }
}
