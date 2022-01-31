using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CRUD_Alumnos.Models;


namespace CRUD_Alumnos.Models.Entity
{
    public  class Alumno
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

        public int idCiudad { get; set; }

        public DateTime FechaRegistro { get; set; }

        public virtual Ciudad Ciudad { get; set; }

      //  public string NombreCompleto { get { return Nombres + " " + Apellidos; } }

    }






}