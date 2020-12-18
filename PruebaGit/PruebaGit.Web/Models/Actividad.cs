using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Models
{
    public class Actividad
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Actividad")]
        public int ActividadId { get; set; }


        public ICollection<AgregarActividad> AgregarActividads { get; set; }

    }
}