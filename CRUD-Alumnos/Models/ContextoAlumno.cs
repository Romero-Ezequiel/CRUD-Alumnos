using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CRUD_Alumnos.Models
{
    public partial class ContextoAlumno : DbContext
    {
        public ContextoAlumno()
            : base("name=ContextoAlumno")
        {
        }

        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .Property(e => e.Apellidos)
                .IsFixedLength();

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ciudad>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Ciudad>()
                .HasMany(e => e.Alumno)
                .WithOptional(e => e.Ciudad)
                .HasForeignKey(e => e.idCiudad);
        }
    }
}
