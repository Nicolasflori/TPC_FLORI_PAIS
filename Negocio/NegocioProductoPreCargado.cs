using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioProductoPreCargado
    {
        public List<ProductoPreCargado> listar()
        {
            List<ProductoPreCargado> lista = new List<ProductoPreCargado>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, IDColor, IDCategoria, IDEstampado, FechaCarga FROM ProductoPreCargado where baja=0;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new ProductoPreCargado
                    {
                        ID = (int)datos.Lector["ID"],
                        IDColor = (int)datos.Lector["IDColor"],
                        IDCategoria = (int)datos.Lector["IDCategoria"],
                        IDEstampado = (int)datos.Lector["IDEstampado"],
                        FechaCarga = (DateTime)datos.Lector["FechaCarga"]
                    };

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        //public List<ProductoPreCargado> buscar(int id)
        //{
        //    List<ProductoPreCargado> lista = new List<ProductoPreCargado>();
        //    AccesoDatos datos = new AccesoDatos();
        //    try
        //    {
        //        datos.setearConsulta("SELECT ID, IDColor, IDCategoria, IDEstampado, FechaCarga FROM ProductoPreCargado;");
        //        datos.ejecutarLectura();

        //        while (datos.Lector.Read())
        //        {
        //            var aux = new ProductoPreCargado
        //            {
        //                ID = (int)datos.Lector["ID"],
        //                IDColor = (int)datos.Lector["IDColor"],
        //                IDCategoria = (int)datos.Lector["IDCategoria"],
        //                IDEstampado = (int)datos.Lector["IDEstampado"],
        //                FechaCarga = (DateTime)datos.Lector["FechaCarga"]
        //            };

        //            lista.Add(aux);
        //        }
        //        return lista;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}

        public void agregar(ProductoPreCargado nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values(" + "'" + nuevo.IDColor + "'" + ", '" + nuevo.IDCategoria + "'" + ", '" + nuevo.IDEstampado + "')";
                datos.setearConsulta("insert into ProductoPreCargado (IDColor, IDCategoria, IDEstampado)" + valores);
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(ProductoPreCargado nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update ProductoPreCargado SET IDColor= '" + nuevo.IDColor + "', IDCategoria= '" + nuevo.IDCategoria + "', IDEstampado= '" + nuevo.IDEstampado +  "' WHERE id= " + nuevo.ID);
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ProductoPreCargado SET baja=1 Where Id = " + id);
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
