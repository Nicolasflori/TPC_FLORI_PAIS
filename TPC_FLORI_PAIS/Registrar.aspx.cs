using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace TPC_FLORI_PAIS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public Usuarios usuario;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonRegistrar_Click(object sender, EventArgs e)
        {
            NegocioUsuarios NegocioUsuarios = new NegocioUsuarios();
            usuario = new Usuarios();
            usuario.Usuario = Request.Form.Get("usuario");
            usuario.Contraseña = Request.Form.Get("contraseña");
            usuario.Nombre = Request.Form.Get("nombre");
            usuario.Apellido = Request.Form.Get("apellido");
            usuario.Email = Request.Form.Get("email");

            if (NegocioUsuarios.buscarUsuario(usuario.Usuario) == true)
            {
                var page = HttpContext.Current.CurrentHandler as Page;
                ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "El usuario ya existe!" + "');window.location ='" + "Registrar.aspx" + "';", true);
            }
            else if (usuario.Usuario.Length > 12)
            {
                var page = HttpContext.Current.CurrentHandler as Page;
                ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "El usuario debe tener menos de 12 caracteres!" + "');window.location ='" + "Registrar.aspx" + "';", true);
            }
            else if (usuario.Usuario.Length < 4)
            {
                var page = HttpContext.Current.CurrentHandler as Page;
                ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "El usuario debe tener 4 caracteres o más!" + "');window.location ='" + "Registrar.aspx" + "';", true);
            }
            else if (usuario.Contraseña != Request.Form.Get("confirmar_contraseña"))
            {
                var page = HttpContext.Current.CurrentHandler as Page;
                ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "Las contraseñas no coinciden!" + "');window.location ='" + "Registrar.aspx" + "';", true);
            }
            else if (usuario.Contraseña.Length < 5)
            {
                var page = HttpContext.Current.CurrentHandler as Page;
                ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "La contraseña debe tener mas de 5 caracteres!" + "');window.location ='" + "Registrar.aspx" + "';", true);
            }
            else if (NegocioUsuarios.buscarMailExistente(usuario.Email) == true)
            {
                var page = HttpContext.Current.CurrentHandler as Page;
                ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "EMail ya registrado!" + "');window.location ='" + "Registrar.aspx" + "';", true);
            }
            else
            {
                NegocioUsuarios.agregar(usuario);
                var page = HttpContext.Current.CurrentHandler as Page;
                ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "Usuario Registrado con Éxito!" + "');window.location ='" + "Default.aspx" + "';", true);
            }
        }
    }
}