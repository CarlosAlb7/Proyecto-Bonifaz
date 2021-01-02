using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaGit.Web.Models
{
    public class Citas
    {
        public int Id { get; set; }
        [Display(Name = "No. Cita")]
        public int No_Cita { get; set; }

        [Display(Name = "CURP")]
        public string CURP { get; set; }
        [Display(Name = "Correo electronico")]
        public string Correo { get; set; }
        [Display(Name = "Dia")]
        public string Dia { get; set; }
        [Display(Name = "Mes")]
        public string Mes { get; set; }
        [Display(Name = "Año")]
        public string Año { get; set; }
        [Display(Name = "Hora")]
        public string Hora { get; set; }
        [Display(Name = "Doctor")]
        public int DoctorId { get; set; }

        //IDENTIFICAR LA VARIABLE FORANEA
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }
    }
}