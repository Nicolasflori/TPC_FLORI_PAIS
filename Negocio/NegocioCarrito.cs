using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioCarrito
    {
        public List<Carrito> listar()
        {
            List<Carrito> lista = new List<Carrito>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Estado FROM Carrito WHERE baja=0");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Carrito
                    {
                        ID = (int)datos.Lector["ID"],
                        Estado = (string)datos.Lector["Estado"],
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

        public void agregar(Carrito nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('" + nuevo.Estado + "')";
                datos.setearConsulta("insert into Carrito (Estado)" + valores);
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

        public void modificar(Carrito Carrito)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Carrito SET Estado='" + Carrito.Estado + "' WHERE ID=" + Carrito.ID);
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
                datos.setearConsulta("UPDATE Carritoes SET baja=1 Where Id = " + id);
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

        public string descripcionxid(int id)
        {
            string descripcion = null;
            List<Carrito> lista = new List<Carrito>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Estado FROM Carrito;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Carrito
                    {
                        ID = (int)datos.Lector["ID"],
                        Estado = (string)datos.Lector["Estado"],
                    };

                    lista.Add(aux);
                }
                foreach (Carrito item in lista)
                {
                    if (id == item.ID)
                        return item.Estado;

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return descripcion;
        }
    }
}
