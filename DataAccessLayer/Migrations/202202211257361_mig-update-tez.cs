namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migupdatetez : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.DokTezDans", newName: "DokTezDanis");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.DokTezDanis", newName: "DokTezDans");
        }
    }
}
