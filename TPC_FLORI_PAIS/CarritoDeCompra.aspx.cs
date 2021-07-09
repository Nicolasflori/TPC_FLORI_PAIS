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
    }
}