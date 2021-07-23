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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void buttonIngresar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            NegocioUsuarios negocio = new NegocioUsuarios();
            try
            {
                usuario = new Usuarios() ;
                usuario.Usuario = Request.Form.Get("usuario");
                usuario.Contraseña = Request.Form.Get("contraseña");
                if(negocio.loguear(usuario))
                {
                    Session.Add("usuario", usuario);
                    var page = HttpContext.Current.CurrentHandler as Page;
                    ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "Usuario logueado con Éxito!" + "');window.location ='" + "Default.aspx" + "';", true);
                    var listaproducto = (List<Producto>)Application["ListadosProductos"];
                    if (listaproducto != null)
                    {
                        Response.Redirect("CarritoDeCompra.aspx");
                    }

                }
                else
                {
                    Session.Add("error", "Usuario o Contraseña incorrecta");
                    var page = HttpContext.Current.CurrentHandler as Page;
                    ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "Usuario o Contraseña incorrecta" + "');window.location ='" + "Default.aspx" + "';", true);
                }


            }
            catch (Exception)
            {

                throw;
            }
            
            //Response.Redirect("Error.aspx");
        }
    }
}