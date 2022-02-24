namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migaddguncelyazilaruptadesdads : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GuncelYazilars", "Title", c => c.String(maxLength: 300));
            AddColumn("dbo.GuncelYazilars", "File", c => c.String(maxLength: 300));
            DropColumn("dbo.GuncelYazilars", "YaziTitle");
            DropColumn("dbo.GuncelYazilars", "Desc");
            DropColumn("dbo.GuncelYazilars", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GuncelYazilars", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.GuncelYazilars", "Desc", c => c.String());
            AddColumn("dbo.GuncelYazilars", "YaziTitle", c => c.String(maxLength: 300));
            DropColumn("dbo.GuncelYazilars", "File");
            DropColumn("dbo.GuncelYazilars", "Title");
        }
    }
}
