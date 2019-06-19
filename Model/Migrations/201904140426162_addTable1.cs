namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTable1 : DbMigration
    {
        public override void Up()
        {
              /*CreateTable(
                  "dbo.User",
                  c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 250, unicode: true),
                        Code = c.String(maxLength: 10, unicode: false),
                        MetaTitle = c.String(maxLength: 250, unicode: true),
                        Description = c.String(maxLength: 500, unicode: true),
                        Image = c.String(maxLength: 250, unicode: true),
                        MoreImages = c.String(maxLength: 250, unicode: true),

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
                   .PrimaryKey(t => t.ID);*/

        }

        public override void Down()
        {
        }
    }
}
