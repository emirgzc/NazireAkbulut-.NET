namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migstart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutId = c.Int(nullable: false, identity: true),
                        Image = c.String(maxLength: 150),
                        Title = c.String(maxLength: 100),
                        Desc = c.String(),
                    })
                .PrimaryKey(t => t.AboutId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(maxLength: 150),
                        Email = c.String(maxLength: 100),
                        Subject = c.String(maxLength: 300),
                        Message = c.String(),
                        ContactDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.Kitaps",
                c => new
                    {
                        KitapID = c.Int(nullable: false, identity: true),
                        KitapTitle = c.String(maxLength: 300),
                        KitapDesc = c.String(),
                        KitapImage = c.String(maxLength: 150),
                        KitapDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.KitapID);
            
            CreateTable(
                "dbo.Makales",
                c => new
                    {
                        MakaleID = c.Int(nullable: false, identity: true),
                        MakaleTitle = c.String(maxLength: 300),
                        MakaleDesc = c.String(),
                        MakaleDate = c.DateTime(nullable: false),
                        MakaleStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MakaleID);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        SliderId = c.Int(nullable: false, identity: true),
                        Image = c.String(maxLength: 150),
                    })
                .PrimaryKey(t => t.SliderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sliders");
            DropTable("dbo.Makales");
            DropTable("dbo.Kitaps");
            DropTable("dbo.Contacts");
            DropTable("dbo.Abouts");
        }
    }
}
