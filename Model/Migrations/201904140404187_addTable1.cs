namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTable1 : DbMigration
    {
        public override void Up()
        {
            

        }

        public override void Down()
        {
            DropTable("dbo.Category");
        }
    }
}
