namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartFormulario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Formularios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Destino = c.String(),
                        Asunto = c.String(),
                        Mensaje = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Formularios");
        }
    }
}
