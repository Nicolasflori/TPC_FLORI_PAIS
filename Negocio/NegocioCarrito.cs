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
        public List<Carrito> listar(int idUsuario)
        {
            List<Carrito> lista = new List<Carrito>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Estado FROM Carrito");
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

        public int ultimoCarrito()
        {
            List<Carrito> lista = new List<Carrito>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT MAX(ID) AS ID FROM Carrito");
                datos.ejecutarLectura();

                int idCarrito=0;
                while (datos.Lector.Read())
                {
                    idCarrito = (int)datos.Lector["ID"];
                }

                return idCarrito;
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

        public int agregar(Carrito nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values(" + nuevo.IDUsuario + ", " + 
                                             nuevo.SubTotalProductos.ToString().Replace(",", ".") + ", " + 
                                             nuevo.CostoDeEnvio.ToString().Replace(",", ".") + ", " + 
                                             nuevo.Total.ToString().Replace(",", ".") + ", '" + 
                                             nuevo.Estado + "' , '" + 
                                             nuevo.FormaPago + "', '" + 
                                             nuevo.FechaEntrega.ToString("dd/MM/yyyy") + "')";
                datos.setearConsulta("insert into Carrito (IDUsuario, SubTotalProductos, CostoDeEnvio, Total, Estado, FormaPago, FechaEntrega)" + valores);
                datos.ejectutarAccion();
                
                return ultimoCarrito();
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

        public void agregarDet(Producto producto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values(" + producto.IDEstampado + ", " +
                                             producto.IDColor + ", " +
                                             producto.IDCategoria + ", " +
                                             producto.IDTalle + ", " +
                                             producto.Precio.ToString().Replace(",", ".") + ", " +
                                             producto.Cantidad + " , " +
                                             producto.PrecioxProducto.ToString().Replace(",", ".") + ", " +
                                             producto.IDCarrito + ")";
                datos.setearConsulta("insert into CarritoDet (IDEstampado, IDColor, IDCategoria, IDTalle, Precio, Cantidad, PrecioxProducto, IDCarrito)" + valores);
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
    }
}
