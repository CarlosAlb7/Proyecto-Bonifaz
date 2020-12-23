using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
///Librerias para usar SQL CLIENT/
using System.Data;
using System.Data.SqlClient;

namespace PruebaGit.Web.Models
{
    public class ProductosDAL
    {
        IDbConnection _conn = DBCommon.Conexion();

        //metodo para agregar//

        public int AgregarProducto(ProductosEN pEN)
        {
            _conn.Open();
            SqlCommand _Comand = new SqlCommand("AgregarProductos", _conn as SqlConnection);
            _Comand.CommandType = CommandType.StoredProcedure;
            _Comand.Parameters.Add(new SqlParameter("@Nombre", pEN.Nombre));
            _Comand.Parameters.Add(new SqlParameter("@Imagen", pEN.Imagen));
            _Comand.Parameters.Add(new SqlParameter("@Telefono", pEN.Telefono));
            _Comand.Parameters.Add(new SqlParameter("@Especialidad", pEN.Especialidad));
            _Comand.Parameters.Add(new SqlParameter("@Servicio", pEN.Servicio));
            int Resultado = _Comand.ExecuteNonQuery();
            _conn.Close();
            return Resultado;


        }

        //metodo para consultar productos
        public List<ProductosEN> ConsultarProductos()
        {
            _conn.Open();
            SqlCommand _comand = new SqlCommand("ConsultarProductos", _conn as SqlConnection);
            _comand.CommandType = CommandType.StoredProcedure;
            IDataReader _reader = _comand.ExecuteReader();
           
            List<ProductosEN> _lista = new List<ProductosEN>();
            while(_reader.Read())
            {
                ProductosEN pEN = new ProductosEN();
                pEN.Id = _reader.GetInt64(0);
                pEN.Nombre = _reader.GetString(1);
                pEN.Imagen = _reader.GetString(2);
                pEN.Telefono = _reader.GetString(3);
                pEN.Especialidad = _reader.GetString(4);
                pEN.Servicio = _reader.GetString(5);
                _lista.Add(pEN);
            
            }
          
            _conn.Close();
            return _lista;
        }

    }
}