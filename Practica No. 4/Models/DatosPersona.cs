using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace Practica_No._4.Models
{
    public class DatosPersona
    {
        public void GrabarDatos(string nombre, string cedula, string telefono, string correo)
        {
            StreamWriter archivo = new StreamWriter(HostingEnvironment.MapPath("~") + "App_Data/datos_persona.txt", true);
            archivo.WriteLine("Nombre: " + nombre + "<br>cedula: " + cedula + "<br>telefono: " + telefono + "<br>correo: " + correo + "<hr>");
            archivo.Close();
        }

        public string LeerDatos()
        {
            StreamReader archivo = new StreamReader(HostingEnvironment.MapPath("~") + "App_Data/datos_persona.txt");
            string todo = archivo.ReadToEnd();
            archivo.Close();
            return todo;
        }
    }
}