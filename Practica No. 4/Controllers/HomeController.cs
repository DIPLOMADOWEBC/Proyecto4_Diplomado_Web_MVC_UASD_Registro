using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practica_No._4.Models;

namespace Practica_No._4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormularioVisita()
        {
            return View();
        }
        
        //[HttpPost]
        public ActionResult CargaDatos()
        {
            string nombre = Request.Form["nombre"].ToString();
            string comentarios = Request.Form["comentarios"].ToString();
            LibroVisitas libro = new LibroVisitas();
            libro.Grabar(nombre, comentarios);
            return View();
        }

        public ActionResult ListadoVisitas()
        {
            LibroVisitas libro = new LibroVisitas();
            string todo = libro.Leer();
            ViewBag.libro = todo;
            
            return View();
        }

        //Datos persona
        public ActionResult DatosPersona()
        {

            return View();
        }
        public ActionResult CargaDatosPersona()
        {
            string nombre = Request.Form["nombre"].ToString();
            string cedula = Request.Form["cedula"].ToString();
            string telefono = Request.Form["telefono"].ToString();
            string correo = Request.Form["correo"].ToString();
            DatosPersona persona = new DatosPersona();
            persona.GrabarDatos(nombre, cedula, telefono, correo);
            //return RedirectToAction("Index");
            return View();
        }
        public ActionResult VerPersonas()
        {
            DatosPersona persona = new DatosPersona();
            string todo = persona.LeerDatos();
            ViewBag.persona = todo;

            return View();
        }
    }
}