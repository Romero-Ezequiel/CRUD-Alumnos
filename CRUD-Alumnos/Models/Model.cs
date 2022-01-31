using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CRUD_Alumnos.Models
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

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
                .WithRequired(e => e.Ciudad)
                .HasForeignKey(e => e.idCiudad)
                .WillCascadeOnDelete(false);
        }
    }
}
