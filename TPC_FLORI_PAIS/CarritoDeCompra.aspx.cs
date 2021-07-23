using System;
using System.Collections.Generic;
using System.Data;
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
        List<Producto> listaproducto = new List<Producto>();
        protected void Page_Load(object sender, EventArgs e)
        {
            NegocioColores NegocioColores = new Negocio.NegocioColores();
            NegocioCategorias NegocioCategorias = new Negocio.NegocioCategorias();
            NegocioEstampado NegocioEstampado = new Negocio.NegocioEstampado();
            NegocioTalles NegocioTalles = new Negocio.NegocioTalles();
           
             listaproducto = (List<Producto>)Application["ListadosProductos"];
            Carrito carrito = new Carrito();

            if (listaproducto != null)
            { 
                foreach (Producto producto in listaproducto)
                {
                    producto.Categoria = NegocioCategorias.descripcionxid(producto.IDCategoria);
                    producto.Color = NegocioColores.descripcionxid(producto.IDColor);
                    producto.Estampado = NegocioEstampado.descripcionxid(producto.IDEstampado);
                    producto.Talle = NegocioTalles.descripcionxid(producto.IDTalle);
                }
            }

            carrito.Items= listaproducto;

            Repetidor.DataSource = carrito.Items;

            Repetidor.DataBind();
        }

        

        protected void Repetidor_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            var listaproducto = (List<Producto>)Application["ListadosProductos"];
            listaproducto.RemoveAt(index);

            var carrito = new Carrito();
            carrito.Items = listaproducto;
            Repetidor.DataSource = carrito.Items;
            Repetidor.DataBind();
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btn_Comprar_Click(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                Application["ListadosProductos"] = listaproducto;
                Response.Redirect("FinalizarCompra.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}