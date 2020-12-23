using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PruebaGit.Web.Models;

namespace PruebaGit.Web.Controllers
{
    public class ProductosController : Controller
    {
        //Comunicacion entre clases 
        ProductosBL _bl = new ProductosBL();
        // GET: Productos
        public ActionResult Index()
        {
            ViewBag.ListaProductos = _bl.ConsultarProductos().ToList();
            return View();
        }
        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        ///Pase de parametros de metodos/
        public ActionResult Agregar(ProductosEN pEN)
        {
            _bl.AgregarProducto(pEN);
            return RedirectToAction("Index");

        }
    }
}