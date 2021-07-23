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
        public List<Carrito> listar(Usuarios usuario)
        {
            var lista = new List<Carrito>();
            var datos = new AccesoDatos();
            string query = "";

            try
            {
                if (usuario.IDPermiso == 1)
                {
                    // Usuario Administrador
                    query = "SELECT ID, IDUsuario, SubTotalProductos, CostoDeEnvio, Total, Estado, FormaPago, Fecha, FechaEntrega FROM Carrito";
                }
                else if (usuario.IDPermiso == 2)
                {
                    // Usuario Cliente
                    query = "SELECT ID, IDUsuario, SubTotalProductos, CostoDeEnvio, Total, Estado, FormaPago, Fecha, FechaEntrega FROM Carrito WHERE IDUsuario = " + usuario.ID;
                }

                datos.setearConsulta(query);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Carrito
                    {
                        ID = (int)datos.Lector["ID"],
                        IDUsuario = (int)datos.Lector["IDUsuario"],
                        SubTotalProductos = (decimal)datos.Lector["SubTotalProductos"],
                        CostoDeEnvio = 405,
                        Total = (decimal)datos.Lector["Total"],
                        Estado = (string)datos.Lector["Estado"],
                        FormaPago = (string)datos.Lector["FormaPago"],
                        Fecha = (DateTime)datos.Lector["Fecha"],
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

        public List<Producto> listarDet(int idCarrito)
        {
            var lista = new List<Producto>();
            var datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT ID, IDEstampado, IDColor, IDCategoria, IDTalle, Precio, Cantidad, PrecioxProducto, IDCarrito FROM CarritoDet WHERE IDCarrito = " + idCarrito);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Producto
                    {
                        ID = (int)datos.Lector["ID"],
                        IDEstampado = (int)datos.Lector["IDEstampado"],
                        IDColor = (int)datos.Lector["IDColor"],
                        IDCategoria = (int)datos.Lector["IDCategoria"],
                        IDTalle = (int)datos.Lector["IDTalle"],
                        Precio = (decimal)datos.Lector["Precio"],
                        Cantidad = (int)datos.Lector["Cantidad"],
                        PrecioxProducto = (decimal)datos.Lector["PrecioxProducto"],
                        IDCarrito = (int)datos.Lector["IDCarrito"],
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
                                             nuevo.FormaPago + " ')";
                datos.setearConsulta("insert into Carrito (IDUsuario, SubTotalProductos, CostoDeEnvio, Total, Estado, FormaPago)" + valores);
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
