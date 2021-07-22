using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioUsuarios
    {
        public void agregar(Usuarios nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values(" + "'" + nuevo.Usuario + "'" + ", '" + nuevo.Contraseña + "'" + ", '" + nuevo.Nombre + "'" + ", '" + nuevo.Apellido + "'" + ", '" + nuevo.Email + "')";
                datos.setearConsulta("insert into Usuarios (Usuario, Contraseña, Nombre, Apellido, Email)" + valores);
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

        public bool loguear(Usuarios usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, IDPermiso FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña");
                datos.agregarParametro("@Usuario", usuario.Usuario);
                datos.agregarParametro("@Contraseña", usuario.Contraseña);

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    usuario.ID = (int)datos.Lector["ID"];
                    usuario.IDPermiso = (int)datos.Lector["IDPermiso"];
                    return true;
                }
                return false;
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
