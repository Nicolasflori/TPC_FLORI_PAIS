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
                string valores = "values(" + "'" + nuevo.Usuario + "'" + ", '" + nuevo.Contraseña + "'" + ", '" + nuevo.Nombre + "'" + ", '" + nuevo.Apellido + "'" + ", '" + nuevo.DNI + "'" + ", '" + nuevo.Email + "'" + ", '" + nuevo.Telefono + "')";
                datos.setearConsulta("insert into Usuarios (Usuario, Contraseña, Nombre, Apellido, DNI, Email, Telefono)" + valores);
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
