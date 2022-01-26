namespace CRUD_Alumnos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alumnos03 : DbMigration
    {
        //Actualizacion
        public override void Up()
        {
            DropColumn("dbo.Alumno", "Domicilio");
        }
        
        //Lo que estaba
        public override void Down()
        {
            AddColumn("dbo.Alumno", "Domicilio", c => c.String());
        }
    }
}
