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
            try
            {
                /*Cuando usamos más de una tabla tenemos que usar transaciones */
                using (var db = new ModelAlumnos())
                {
                    //List<Alumno> lista = db.Alumno.Where(a => a.Edad > 18).ToList();  
                    return View(db.Alumno.ToList());
                    //return View(lista);

                }

            }
            catch (Exception)
            {
                throw;
            }

            //db.Alumno.ToList();
            //List<Alumno> lista = db.Alumno.Where(a => a.Edad > 18).ToList();  
            // db.Alumno.Where(a => a.Edad > 18).ToList();
            //return View(lista);
        }

        [HttpGet]
        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        //Esto crea un token que verifica que el formulario que se envia es el correcto
        [ValidateAntiForgeryToken]
        public ActionResult Agregar(Alumno a)
        {
            //Aca consulto sobre si, el modelo que entra es valido y sino es valido 
            //me retorna la vista y los errores que hay en ValitionSummary
            if (!ModelState.IsValid)
                return View();

            try
            {
                //Es importante utilizar el using para que abra la conexion
                //y a la vez que la cierre para que no quede una conexion abierta
                //y no este consumiendo mucho recursos
                using (ModelAlumnos db = new ModelAlumnos())
                {
                    a.FechaRegistro = DateTime.Now;

                    //Agrego un alumno
                    db.Alumno.Add(a);
                    //Guardo los cambios
                    db.SaveChanges();

                    //return View();
                    //Cuando esta todo bien utilizo un redirect para direccionarlo 
                    return RedirectToAction("Index");

                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al agregar un Alumno", ex.Message);

                return View();
            }
        }



        public ActionResult Editar(int id)
        {
            try
            {
                using (var db = new ModelAlumnos())
                {
                    //Alumno alumnos = db.Alumno.Where(a => a.Id == id).FirstOrDefault();
                    Alumno alum = db.Alumno.Find(id);
                    return View(alum);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Alumno a)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View();
                using (var db = new ModelAlumnos())
                {
                    Alumno al = db.Alumno.Find(a.Id);
                    al.Nombres = a.Nombres;
                    al.Apellidos = a.Apellidos;
                    al.Edad = a.Edad;
                    al.Sexo = a.Sexo;

                    //Para guardar los cambios
                    db.SaveChanges();
                    //Una vez guardado lo redirecciono a index
                    return RedirectToAction("Index");

                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public ActionResult DetallesAlumno(int id)
        {
            try
            {
                using (var db = new ModelAlumnos())
                {
                    //Alumno alumnos = db.Alumno.Where(a => a.Id == id).FirstOrDefault();
                    Alumno alum = db.Alumno.Find(id);
                    return View(alum);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public ActionResult Eliminar(int id )
        {
            try
            {
                using (var db = new ModelAlumnos())
                {
                    //Alumno alumnos = db.Alumno.Where(a => a.Id == id).FirstOrDefault();
                    //Primero lo buscamos y si lo encontramos lo eliminamos y luego guardamos
                    Alumno alum = db.Alumno.Find(id);
                    db.Alumno.Remove(alum);
                    db.SaveChanges();
                    
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}