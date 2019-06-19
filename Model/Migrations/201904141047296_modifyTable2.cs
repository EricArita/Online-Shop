namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyTable2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Content", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Content", "Status", c => c.Boolean());
        }
    }
}
