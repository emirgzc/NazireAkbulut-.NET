namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migupdatedescslider : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sliders", "SliderDesc", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sliders", "SliderDesc", c => c.String(maxLength: 150));
        }
    }
}
