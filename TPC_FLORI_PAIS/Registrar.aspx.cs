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
            this.usuario = new Usuarios();
            usuario.Usuario = Request.Form.Get("usuario");
            usuario.Contraseña = Request.Form.Get("contraseña");
            usuario.Nombre = Request.Form.Get("nombre");
            usuario.Apellido = Request.Form.Get("apellido");
            usuario.Email = Request.Form.Get("email");
            usuario.DNI = Request.Form.Get("dni");
            usuario.Telefono = Request.Form.Get("telefono");

            NegocioUsuarios.agregar(usuario);
            var page = HttpContext.Current.CurrentHandler as Page;
            ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "Usuario Registrado con Éxito!" + "');window.location ='" + "Default.aspx" + "';", true);
        }
    }
}