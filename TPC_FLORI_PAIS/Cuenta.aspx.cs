using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_FLORI_PAIS
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        public Usuarios usuario;
        public Direccion direccion;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonGuardar_Click(object sender, EventArgs e)
        {
            NegocioUsuarios negocioUsuarios = new NegocioUsuarios();
            NegocioDireccion negocioDireccion = new NegocioDireccion();

            ////Te genera un nuevo usuario y se pisa el usuario logueado
            usuario = new Usuarios();
            direccion = new Direccion();

            usuario.Nombre = Request.Form.Get("nombre");
            usuario.Apellido = Request.Form.Get("apellido");
            usuario.Email = Request.Form.Get("email");
            usuario.DNI = Request.Form.Get("dni");
            usuario.Telefono = Request.Form.Get("telefono");
            usuario.ID = ((Dominio.Usuarios)Session["usuario"]).ID;

            direccion.IDCiudad = negocioDireccion.buscarIDCiudad(Request.Form.Get("ciudad"));
            direccion.IDProvincia = negocioDireccion.buscarIDProvincia(Request.Form.Get("provincia"));
            direccion.Calle = Request.Form.Get("calle");
            direccion.Numeracion = Int32.Parse(Request.Form.Get("numeracion")); 
            direccion.Piso = Request.Form.Get("piso");
            direccion.Depto = Request.Form.Get("depto");
            direccion.CP = Request.Form.Get("cp");

            if (negocioUsuarios.chequearDireccion(((Dominio.Usuarios)Session["usuario"]).ID) == false)
            {
                negocioDireccion.agregar(direccion);
                negocioDireccion.setearIDDireccion(((Dominio.Usuarios)Session["usuario"]).ID);
            }
            else
            {
                direccion.ID = negocioUsuarios.getIDDireccion(((Dominio.Usuarios)Session["usuario"]).ID);
                negocioDireccion.modificar(direccion);
            }

            negocioUsuarios.modificar(usuario);

            var page = HttpContext.Current.CurrentHandler as Page;
            ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "Usuario Modificado con Éxito!" + "');window.location ='" + "Default.aspx" + "';", true);

            Response.Redirect("Default.aspx");
        }

    }
}