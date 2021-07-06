using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioColores
    {
        public List<Color> listar()
        {
            List<Color> lista = new List<Color>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Descripcion FROM Colores;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Color
                    {
                        ID = (int)datos.Lector["ID"],
                        Descripcion = (string)datos.Lector["Descripcion"],
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

        public void agregar(ProductoPreCargado nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values(" + "'" + nuevo.IDColor + "'" + ", '" + nuevo.IDCategoria + "'" + ", '" + nuevo.IDEstampado + "'" + ", '" + nuevo.FechaCarga + "')";
                datos.setearConsulta("insert into ProductoPreCargado (IDColor, IDCategoria, IDEstampado, FechaCarga)" + valores);
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
                datos.setearConsulta("Update ProductoPreCargado SET IDColor= '" + nuevo.IDColor + "', IDCategoria= '" + nuevo.IDCategoria + "', IDEstampado= '" + nuevo.IDEstampado + "', FechaCarga= '" + nuevo.FechaCarga + "' WHERE id= " + nuevo.ID);
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
                datos.setearConsulta("Delete From ProductoPreCargado Where Id = " + id);
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
