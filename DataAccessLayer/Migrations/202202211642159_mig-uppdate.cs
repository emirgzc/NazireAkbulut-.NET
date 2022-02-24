namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class miguppdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SemKonBilDanKurUyes", "File", c => c.String(maxLength: 150));
            DropColumn("dbo.Abouts", "Image");
            DropColumn("dbo.SemKonBilDanKurUyes", "Title");
            DropColumn("dbo.SemKonBilDanKurUyes", "URL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SemKonBilDanKurUyes", "URL", c => c.String(maxLength: 150));
            AddColumn("dbo.SemKonBilDanKurUyes", "Title", c => c.String(maxLength: 150));
            AddColumn("dbo.Abouts", "Image", c => c.String(maxLength: 150));
            DropColumn("dbo.SemKonBilDanKurUyes", "File");
        }
    }
}
