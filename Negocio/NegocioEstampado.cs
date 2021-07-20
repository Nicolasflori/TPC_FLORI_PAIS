using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
   public class NegocioEstampado
    {
        public List<Estampado> listar()
        {
            List<Estampado> lista = new List<Estampado>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Descripcion, Imagen, Precio FROM Estampados WHERE baja=0;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Estampado
                    {
                        ID = (int)datos.Lector["ID"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        Imagen= (string)datos.Lector["Imagen"],
                        Precio = (decimal)datos.Lector["Precio"],
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

        public void agregar(Estampado nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values(" + "'" + nuevo.Descripcion + "'" + "," + "'" + nuevo.Imagen + "'" + ", '" + nuevo.Precio + "')";
                datos.setearConsulta("insert into Estampados (Descripcion,Imagen, Precio)" + valores);
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

        public void modificar(Estampado nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Estampados SET Descripcion= '" + nuevo.Descripcion + "', Imagen=' " + nuevo.Imagen + " ', Precio= '" + nuevo.Precio +"' where ID= '" +nuevo.ID+"'" );
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
                datos.setearConsulta("UPDATE Estampados SET baja = 1 Where Id = " + id);
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
            List<Estampado> lista = new List<Estampado>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Descripcion, Precio FROM Estampados;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Estampado
                    {
                        ID = (int)datos.Lector["ID"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        Precio = (decimal)datos.Lector["Precio"],
                    };

                    lista.Add(aux);
                }
                foreach (Estampado item in lista)
                {
                    if (id == item.ID)
                        return item.Descripcion;

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

        public string imagenxid(int id)
        {
            string imagen = null;
            List<Estampado> lista = new List<Estampado>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Imagen FROM Estampados Where Id = " + id);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Estampado
                    {
                        ID = (int)datos.Lector["ID"],
                        Imagen = (string)datos.Lector["Imagen"],
                    };

                    lista.Add(aux);
                }
                foreach (Estampado item in lista)
                {
                    if (id == item.ID)
                        return item.Imagen;
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

            return imagen;
        }

        public decimal getprecioxid(int id)
        {
            decimal precio = 0;
            List<Estampado> lista = new List<Estampado>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Descripcion, Precio FROM Estampados;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Estampado
                    {
                        ID = (int)datos.Lector["ID"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        Precio = (decimal)datos.Lector["Precio"],
                    };

                    lista.Add(aux);
                }
                foreach (Estampado item in lista)
                {
                    if (id == item.ID)
                        return item.Precio;

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

            return precio;
        }
    }
}

