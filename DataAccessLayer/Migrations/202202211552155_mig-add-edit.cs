namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migaddedit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Editorluks",
                c => new
                    {
                        EditID = c.Int(nullable: false, identity: true),
                        EditTitle = c.String(maxLength: 300),
                        EditDesc = c.String(),
                        EditImage = c.String(maxLength: 150),
                        EditDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EditID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Editorluks");
        }
    }
}
