namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migreset : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.DokTezDanis");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DokTezDanis",
                c => new
                    {
                        TezID = c.Int(nullable: false, identity: true),
                        TezDesc = c.String(maxLength: 500),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TezID);
            
        }
    }
}
