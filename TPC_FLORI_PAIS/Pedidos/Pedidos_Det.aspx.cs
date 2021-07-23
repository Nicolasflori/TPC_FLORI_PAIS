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
    public partial class Pedidos_Det : System.Web.UI.Page
    {
        NegocioCarrito NegocioCarrito = new NegocioCarrito();
        Carrito carrito = new Carrito();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                carrito.Items = NegocioCarrito.listarDet(int.Parse(Request.QueryString["id"]));

                // Mostrar listado
                grid_Productos.DataSource = carrito.Items;
                grid_Productos.DataBind();
            }
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("..\\Pedidos.aspx");
        }

        protected void grid_Productos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //NegocioColores negocioColores = new NegocioColores();
            //NegocioEstampado negocioEstampado = new NegocioEstampado();
            //NegocioCategorias negocioCategorias = new NegocioCategorias();
            //NegocioUsuarios negocioUsuarios
        }
    }
}