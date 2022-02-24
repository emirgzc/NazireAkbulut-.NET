namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migstartUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 100),
                        Password = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.Atiflars",
                c => new
                    {
                        AtiflarID = c.Int(nullable: false, identity: true),
                        File = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.AtiflarID);
            
            CreateTable(
                "dbo.Cevirilers",
                c => new
                    {
                        CevID = c.Int(nullable: false, identity: true),
                        CevFile = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.CevID);
            
            CreateTable(
                "dbo.DigIndYapYayUlusDerYays",
                c => new
                    {
                        DigID = c.Int(nullable: false, identity: true),
                        File = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.DigID);
            
            CreateTable(
                "dbo.DokTezDans",
                c => new
                    {
                        TezID = c.Int(nullable: false, identity: true),
                        TezDesc = c.String(maxLength: 500),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TezID);
            
            CreateTable(
                "dbo.GazeteDergis",
                c => new
                    {
                        GazID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 200),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GazID);
            
            CreateTable(
                "dbo.Konusmacis",
                c => new
                    {
                        KonusmaciID = c.Int(nullable: false, identity: true),
                        File = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.KonusmaciID);
            
            CreateTable(
                "dbo.MesKurUyes",
                c => new
                    {
                        MesKurId = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 150),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MesKurId);
            
            CreateTable(
                "dbo.OturumBaskanliks",
                c => new
                    {
                        OturumBaskanlikID = c.Int(nullable: false, identity: true),
                        File = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.OturumBaskanlikID);
            
            CreateTable(
                "dbo.SemKonBilDanKurUyes",
                c => new
                    {
                        SemID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 150),
                        URL = c.String(maxLength: 150),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SemID);
            
            CreateTable(
                "dbo.UluHakDers",
                c => new
                    {
                        UlusID = c.Int(nullable: false, identity: true),
                        File = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.UlusID);
            
            CreateTable(
                "dbo.YayUlusalBildirs",
                c => new
                    {
                        YayUlusalBildirID = c.Int(nullable: false, identity: true),
                        File = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.YayUlusalBildirID);
            
            CreateTable(
                "dbo.YayUluslararsBildirs",
                c => new
                    {
                        YayUluslararsBildirID = c.Int(nullable: false, identity: true),
                        File = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.YayUluslararsBildirID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.YayUluslararsBildirs");
            DropTable("dbo.YayUlusalBildirs");
            DropTable("dbo.UluHakDers");
            DropTable("dbo.SemKonBilDanKurUyes");
            DropTable("dbo.OturumBaskanliks");
            DropTable("dbo.MesKurUyes");
            DropTable("dbo.Konusmacis");
            DropTable("dbo.GazeteDergis");
            DropTable("dbo.DokTezDans");
            DropTable("dbo.DigIndYapYayUlusDerYays");
            DropTable("dbo.Cevirilers");
            DropTable("dbo.Atiflars");
            DropTable("dbo.Admins");
        }
    }
}
