namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartCitas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Citas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        No_Cita = c.Int(nullable: false),
                        CURP = c.String(),
                        Correo = c.String(),
                        Dia = c.String(),
                        Mes = c.String(),
                        Año = c.String(),
                        Hora = c.String(),
                        DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.DoctorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Citas", "DoctorId", "dbo.Doctors");
            DropIndex("dbo.Citas", new[] { "DoctorId" });
            DropTable("dbo.Citas");
        }
    }
}
