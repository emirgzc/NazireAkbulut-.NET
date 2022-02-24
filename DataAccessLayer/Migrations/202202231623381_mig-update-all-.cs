namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migupdateall : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "Title", c => c.String(maxLength: 250));
            AlterColumn("dbo.MesKurUyes", "Title", c => c.String(maxLength: 300));
            AlterColumn("dbo.Sliders", "SliderTitle", c => c.String(maxLength: 300));
            AlterColumn("dbo.Sliders", "SliderDesc", c => c.String(maxLength: 750));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sliders", "SliderDesc", c => c.String(maxLength: 500));
            AlterColumn("dbo.Sliders", "SliderTitle", c => c.String(maxLength: 150));
            AlterColumn("dbo.MesKurUyes", "Title", c => c.String(maxLength: 150));
            AlterColumn("dbo.Abouts", "Title", c => c.String(maxLength: 100));
        }
    }
}
