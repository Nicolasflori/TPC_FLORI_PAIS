using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_FLORI_PAIS.Pedidos
{
    public partial class Pedidos : System.Web.UI.Page
    {
        NegocioCarrito NegocioCarrito = new NegocioCarrito();
        List<Carrito> carrito = new List<Carrito>();

        protected void Page_Load(object sender, EventArgs e)
        {
            var usuario = new Usuarios();
            usuario = (Usuarios)Session["usuario"];

            if (usuario==null)
            {
                Response.Redirect("..\\Default.aspx");
            }
            
            carrito = NegocioCarrito.listar(usuario);

            // Mostrar listado
            grid_Pedidos.DataSource = carrito;
            grid_Pedidos.DataBind();
        }

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {

        }

        protected void grid_Pedidos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }
    }
}