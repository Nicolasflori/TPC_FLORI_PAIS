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
            NegocioColores NegocioColores = new Negocio.NegocioColores();
            NegocioCategorias NegocioCategorias = new Negocio.NegocioCategorias();
            NegocioEstampado NegocioEstampado = new Negocio.NegocioEstampado();
            NegocioTalles NegocioTalles = new Negocio.NegocioTalles();

            var listaproducto = (List<Producto>)Application["ListadosProductos"];
            ItemCarrito carrito = new ItemCarrito();


            if (listaproducto != null)
            { 
                foreach (Producto producto in listaproducto)
                {
                    producto.Categoria = NegocioCategorias.descripcionxid(producto.IDCategoria);
                    producto.Color = NegocioColores.descripcionxid(producto.IDColor);
                    producto.Estampado = NegocioEstampado.descripcionxid(producto.IDEstampado);
                    producto.Talle = NegocioTalles.descripcionxid(producto.IDTalle+1);
                }
            }

            carrito.Items= listaproducto;

            Repetidor.DataSource = carrito.Items;

            Repetidor.DataBind();

        }

        protected void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var argument = ((Button)sender).CommandArgument;
                List<ItemCarrito> carrito = (List<ItemCarrito>)Session["listaCarrito"];
                ItemCarrito elim = carrito.Find(x => x.ID.ToString() == argument);
                carrito.Remove(elim);
                Session.Add("listadosProductos", carrito);
                Repetidor.DataSource = null;
                Repetidor.DataSource = carrito;
                Repetidor.DataBind();
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx");
            }
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}