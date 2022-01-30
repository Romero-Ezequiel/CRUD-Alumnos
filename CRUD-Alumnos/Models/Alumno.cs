namespace CRUD_Alumnos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Alumno")]
    public partial class Alumno
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(200)]
        public string Apellidos { get; set; }

        public int Edad { get; set; }

        [Required]
        [StringLength(1)]
        public string Sexo { get; set; }

        public int? idCiudad { get; set; }

        public DateTime FechaRegistro { get; set; }

        public virtual Ciudad Ciudad { get; set; }
    }
}
