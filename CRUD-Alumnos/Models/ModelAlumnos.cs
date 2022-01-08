using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CRUD_Alumnos.Models
{
    public partial class ModelAlumnos : DbContext
    {
        public ModelAlumnos()
            : base("name=ModelAlumnos")
        {
        }

        public virtual DbSet<Alumno> Alumno { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .Property(e => e.Apellidos)
                .IsFixedLength();

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
