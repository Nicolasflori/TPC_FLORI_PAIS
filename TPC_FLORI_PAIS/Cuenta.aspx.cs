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
        public Usuarios usuarioAux;
        public Direccion direccion;

        protected void Page_Load(object sender, EventArgs e)
        {
            NegocioUsuarios NegocioUsuarios = new NegocioUsuarios();
            NegocioDireccion NegocioDireccion = new NegocioDireccion();

            //usuarioAux = NegocioUsuarios.buscarUser(((Dominio.Usuarios)Session["usuario"]).ID);
            //direccion = NegocioDireccion.buscarxid(usuarioAux.IDDireccion);

            //txtnombre.Text = usuarioAux.Nombre;
            //txtapellido.Text = usuarioAux.Apellido;
            //txtemail.Text = usuarioAux.Email;
            //txtdni.Text = usuarioAux.DNI;
            //txttelefono.Text = usuarioAux.Telefono;

            //txtciudad.Text = NegocioDireccion.buscarCiudad(direccion.IDCiudad);
            //txtprovincia.Text = NegocioDireccion.buscarProvincia(direccion.IDProvincia);
            //txtcalle.Text = direccion.Calle;
            //txtnumeracion.Text = Convert.ToString(direccion.Numeracion);
            //txtpiso.Text = direccion.Piso;
            //txtdepto.Text = direccion.Depto;
            //txtcp.Text = direccion.CP;
        }

        protected void buttonGuardar_Click(object sender, EventArgs e)
        {
            NegocioUsuarios negocioUsuarios = new NegocioUsuarios();
            NegocioDireccion negocioDireccion = new NegocioDireccion();

            usuarioAux = new Usuarios();
            direccion = new Direccion();

            usuarioAux.Nombre = txtnombre.Text;         
            usuarioAux.Apellido = txtapellido.Text;
            usuarioAux.Email = txtemail.Text;
            usuarioAux.DNI = txtdni.Text;
            usuarioAux.Telefono = txttelefono.Text;
            usuarioAux.ID = ((Dominio.Usuarios)Session["usuario"]).ID;
            direccion.IDCiudad = negocioDireccion.buscarIDCiudad(txtciudad.Text);
            direccion.IDProvincia = negocioDireccion.buscarIDProvincia(txtprovincia.Text);
            direccion.Calle = txtcalle.Text;
            direccion.Numeracion = Int32.Parse(txtnumeracion.Text); 
            direccion.Piso = txtpiso.Text;
            direccion.Depto = txtdepto.Text;
            direccion.CP = txtcp.Text;

            if (negocioUsuarios.chequearDireccion(((Dominio.Usuarios)Session["usuario"]).ID) != false)
            {
                negocioDireccion.agregar(direccion);
                negocioDireccion.setearIDDireccion(((Dominio.Usuarios)Session["usuario"]).ID);
            }
            else
            {
                direccion.ID = negocioUsuarios.getIDDireccion(((Dominio.Usuarios)Session["usuario"]).ID);
                negocioDireccion.modificar(direccion);
            }

            negocioUsuarios.modificar(usuarioAux);

            var page = HttpContext.Current.CurrentHandler as Page;
            ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "Usuario Modificado con Éxito!" + "');window.location ='" + "Default.aspx" + "';", true);

            Response.Redirect("Default.aspx");
        }

    }
}