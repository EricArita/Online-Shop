namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                {
                    ID = c.Long(nullable: false, identity: true),
                    UserName = c.String(maxLength: 50, unicode: false),
                    Password = c.String(maxLength: 32, unicode: false),
                    GroupID = c.String(maxLength: 20),
                    Name = c.String(maxLength: 50),
                    Address = c.String(maxLength: 50),
                    Email = c.String(maxLength: 50),
                    Phone = c.String(maxLength: 50),
                    ProvinceID = c.Int(),
                    DistrictID = c.Int(),
                    CreatedDate = c.DateTime(),
                    CreatedBy = c.String(maxLength: 50, unicode: false),
                    ModifiedDate = c.DateTime(),
                    ModifiedBy = c.String(maxLength: 50, unicode: false),
                    Status = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ID);
        }
        
        public override void Down()
        {
        }
    }
}
