using CRUD_Alumnos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Alumnos.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {

            ModelAlumnos db = new ModelAlumnos();

            db.Alumno.ToList();

           // List<Alumno> lista = db.Alumno.Where(a => a.Edad > 18).ToList();  
            // db.Alumno.Where(a => a.Edad > 18).ToList();

          //  return View(lista);
            return View(db.Alumno.ToList());
        }

        [HttpGet]
        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(Alumno a)
        {
            if (!ModelState.IsValid)
                return View();
            

            

            return View();
        }



    }
}