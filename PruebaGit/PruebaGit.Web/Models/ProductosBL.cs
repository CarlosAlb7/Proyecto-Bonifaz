using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaGit.Web.Models
{
    public class ProductosBL
    {
        ProductosDAL _dal = new ProductosDAL();
        public int AgregarProducto(ProductosEN pEN)
        {
            return _dal.AgregarProducto(pEN);
        }

        public List<ProductosEN> ConsultarProductos()
        {
            return _dal.ConsultarProductos();
        }

      
    }
}