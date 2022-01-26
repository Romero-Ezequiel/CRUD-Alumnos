namespace CRUD_Alumnos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alumnos02 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumno", "Domicilio", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Alumno", "Domicilio");
        }
    }
}
