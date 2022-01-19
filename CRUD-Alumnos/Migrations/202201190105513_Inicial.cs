namespace CRUD_Alumnos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nombres = c.String(nullable: false, maxLength: 200),
                        Apellidos = c.String(nullable: false, maxLength: 200, fixedLength: true),
                        Edad = c.Int(nullable: false),
                        Sexo = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                        FechaRegistro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Alumno");
        }
    }
}
