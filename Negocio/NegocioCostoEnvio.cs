using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
   public class NegocioCostoEnvio
    {

        public List<CostoEnvio> listar()
        {
            List<CostoEnvio> lista = new List<CostoEnvio>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Precio, Zona FROM Categorias;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new CostoEnvio
                    {
                        ID = (int)datos.Lector["ID"], 
                        Precio = (decimal)datos.Lector["Precio"],
                        Zona = (int)datos.Lector["Zona"],
                       

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

        public void agregar(CostoEnvio nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values(" + "'" + nuevo.Precio + "'" + ", '" + nuevo.Zona + "')";
                datos.setearConsulta("insert into CostosDeEnvio (Precio, Zona)" + valores);
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

        public void modificar(CostoEnvio nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update CostosDeEnvio SET Precio= '" + nuevo.Precio + "', Precio= '" + nuevo.Zona);
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
                datos.setearConsulta("Delete From CostoDeEnvio Where Id = " + id);
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

