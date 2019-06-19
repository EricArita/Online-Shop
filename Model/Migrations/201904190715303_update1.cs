namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "CategoryParentID", c => c.Long());
            DropColumn("dbo.Category", "CatetgoryParentID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Category", "CatetgoryParentID", c => c.Long());
            DropColumn("dbo.Category", "CategoryParentID");
        }
    }
}
