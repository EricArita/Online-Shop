namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTable : DbMigration
    {
        public override void Up()
        {                      
            CreateTable(
                "dbo.Credential",
                c => new
                    {
                        UserGroupID = c.String(nullable: false, maxLength: 20),
                        RoleID = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.UserGroupID);           
            
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        ProductID = c.Long(nullable: false),
                        OrderID = c.Long(nullable: false),
                        Quantity = c.Int(),
                        Price = c.Decimal(precision: 18, scale: 0),
                    })
                .PrimaryKey(t => new { t.ProductID, t.OrderID });
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        CreatedDate = c.DateTime(),
                        CustomerID = c.Long(),
                        ShipName = c.String(maxLength: 50),
                        ShipMobile = c.String(maxLength: 50, unicode: false),
                        ShipAddress = c.String(maxLength: 50),
                        ShipEmail = c.String(maxLength: 50),
                        Status = c.Int(),
                    })
                .PrimaryKey(t => t.ID);              
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);                    
                 
            CreateTable(
                "dbo.UserGroup",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 20),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.User",
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
            DropTable("dbo.User");
            DropTable("dbo.UserGroup");
            DropTable("dbo.Tag");
            DropTable("dbo.SystemConfig");
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.Slide");
            DropTable("dbo.Role");
            DropTable("dbo.Product");
            DropTable("dbo.ProductCategory");
            DropTable("dbo.Order");
            DropTable("dbo.OrderDetail");
            DropTable("dbo.MenuType");
            DropTable("dbo.Menu");
            DropTable("dbo.Footer");
            DropTable("dbo.Feedback");
            DropTable("dbo.Credential");
            DropTable("dbo.ContentTag");
            DropTable("dbo.Content");
            DropTable("dbo.Contact");
            DropTable("dbo.Category");
            DropTable("dbo.About");
        }
    }
}
