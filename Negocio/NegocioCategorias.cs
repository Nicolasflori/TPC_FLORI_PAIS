using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
   public class NegocioCategorias
    {

        
            public List<Categoria> listar()
            {
                List<Categoria> lista = new List<Categoria>();
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.setearConsulta("SELECT ID, Descripcion, Precio FROM Categorias;");
                    datos.ejecutarLectura();

                    while (datos.Lector.Read())
                    {
                        var aux = new Categoria
                        {
                            ID = (int)datos.Lector["ID"],
                            Descripcion = (string)datos.Lector["Descripcion"],
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

            public void agregar(Categoria nuevo)
            {
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    string valores = "values(" + nuevo.Descripcion + "'" + ", '" + nuevo.Precio + "')";
                    datos.setearConsulta("insert into Categorias (Descripcion, Precio)" + valores);
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

            public void modificar(Categoria nuevo)
            {
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.setearConsulta("Update Categorias SET Descripcion= '" + nuevo.Descripcion + "', Precio= '" + nuevo.Precio);
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
                    datos.setearConsulta("Delete From Categorias Where Id = " + id);
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
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Descripcion, Precio FROM Categorias;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Categoria
                    {
                        ID = (int)datos.Lector["ID"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        Precio = (decimal)datos.Lector["Precio"],
                    };

                    lista.Add(aux);
                }
                foreach (Categoria item in lista)
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
        public decimal getprecioxid(int id)
        {
            decimal precio = 0;
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Descripcion, Precio FROM Categorias;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Categoria
                    {
                        ID = (int)datos.Lector["ID"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        Precio = (decimal)datos.Lector["Precio"],
                    };

                    lista.Add(aux);
                }
                foreach (Categoria item in lista)
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

