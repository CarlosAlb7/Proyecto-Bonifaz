using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using PruebaGit.Web.Models;

namespace PruebaGit.Web.Controllers
{
 
    public class FormularioController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [HttpGet]
        public ActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Formulario(string Destino, string Asunto, string Mensaje)
        {
            try
            {
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress("danielv210796@gmail.com"); //Email que se usara para enviar correos
                correo.To.Add(Destino);
                correo.Subject = Asunto;
                correo.Body = Mensaje;
                correo.IsBodyHtml = true;
                correo.Priority = MailPriority.Normal;

                //configuracion del servidor smtp

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 80;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = true;
                string sCuentaCorreo = "danielv210796@gmail.com";
                string sPasswordCorreo = "21julio1996AA";
                smtp.Credentials = new System.Net.NetworkCredential(sCuentaCorreo, sPasswordCorreo);

                smtp.Send(correo);
                ViewBag.Mensaje = "Mensaje Enviado con exito";
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return View();

        }
    }
}