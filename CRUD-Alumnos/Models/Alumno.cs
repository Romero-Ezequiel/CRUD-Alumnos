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
        [Display(Name = "Nombre")]
        public string Nombres { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Apellido")]

        public string Apellidos { get; set; }

        [Display(Name = "Edad")]
        public int Edad { get; set; }

        [Required]
        [StringLength(1)]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        [Display(Name = "Ciudad")]
        public int idCiudad { get; set; }

        [Display(Name = "Fecha de alta")]
        public DateTime FechaRegistro { get; set; }

        public virtual Ciudad Ciudad { get; set; }
    }
}
