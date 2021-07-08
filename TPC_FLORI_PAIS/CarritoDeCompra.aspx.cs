using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_PAIS_FLORI
{
    public partial class CarritoDeCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var listaproducto = (List<Producto>)Application["ListadosProductos"];
            ItemCarrito carrito = new ItemCarrito();
            carrito.Items= listaproducto;

            Repetidor.DataSource = carrito.Items;

            Repetidor.DataBind();

        }
    }
}