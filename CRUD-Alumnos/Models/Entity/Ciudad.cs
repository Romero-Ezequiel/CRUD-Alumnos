using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUD_Alumnos.Models;

namespace CRUD_Alumnos.Models.Entity
{
    public class Ciudad
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public virtual ICollection<Alumno> Alumno { get; set; }

    }
}