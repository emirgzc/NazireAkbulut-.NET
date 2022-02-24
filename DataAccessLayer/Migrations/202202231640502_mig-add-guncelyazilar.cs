namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migaddguncelyazilar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GuncelYazilars",
                c => new
                    {
                        YaziID = c.Int(nullable: false, identity: true),
                        YaziTitle = c.String(maxLength: 300),
                        Desc = c.String(),
                        Status = c.Boolean(nullable: false),
                        DateYazi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.YaziID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GuncelYazilars");
        }
    }
}
