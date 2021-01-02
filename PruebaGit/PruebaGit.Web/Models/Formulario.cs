using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Models
{
    public class Formulario
    {
        public int Id { get; set; }
        [Display(Name = "Destino")]
        public string Destino { get; set; }

        [Display(Name = "Asunto")]
        public string Asunto { get; set; }
        [Display(Name = "Mensaje")]
        public string Mensaje { get; set; }
    }
}