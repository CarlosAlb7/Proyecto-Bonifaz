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

        public ActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Formulario(Formulario model)
        {
            //se van agregar las variables para enviar el mensaje 
            //por medio de smtp

            var mensaje = new MailMessage();
            mensaje.Subject = model.Asunto;
            mensaje.Body = model.Mensaje;
            mensaje.To.Add(model.Destino);

            mensaje.IsBodyHtml = true;
            var smtp = new SmtpClient();
            smtp.Send(mensaje);
            return RedirectToAction("Index");
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}