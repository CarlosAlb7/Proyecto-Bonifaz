namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductosBaja : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Formularios", "To");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Formularios", "To", c => c.String());
        }
    }
}
