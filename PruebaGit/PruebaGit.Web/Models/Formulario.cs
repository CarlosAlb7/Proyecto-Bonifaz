using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Models
{
    public class Formulario
    {
        //Agregando los campos que se requieren para enviar el formulario
        //al paciente para confirmarle la cita correspondiente
        public string Destino { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }

    }
}