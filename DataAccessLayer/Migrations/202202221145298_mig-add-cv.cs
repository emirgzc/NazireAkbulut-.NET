namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migaddcv : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AkacemikCVs",
                c => new
                    {
                        CvID = c.Int(nullable: false, identity: true),
                        File = c.String(maxLength: 150),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CvID);
            
            DropTable("dbo.Cevirilers");
            DropTable("dbo.DigIndYapYayUlusDerYays");
            DropTable("dbo.UluHakDers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UluHakDers",
                c => new
                    {
                        UlusID = c.Int(nullable: false, identity: true),
                        File = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.UlusID);
            
            CreateTable(
                "dbo.DigIndYapYayUlusDerYays",
                c => new
                    {
                        DigID = c.Int(nullable: false, identity: true),
                        File = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.DigID);
            
            CreateTable(
                "dbo.Cevirilers",
                c => new
                    {
                        CevID = c.Int(nullable: false, identity: true),
                        CevFile = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.CevID);
            
            DropTable("dbo.AkacemikCVs");
        }
    }
}
