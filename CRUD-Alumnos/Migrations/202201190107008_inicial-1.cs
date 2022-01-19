namespace CRUD_Alumnos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Alumno");
            AlterColumn("dbo.Alumno", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Alumno", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Alumno");
            AlterColumn("dbo.Alumno", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Alumno", "Id");
        }
    }
}
