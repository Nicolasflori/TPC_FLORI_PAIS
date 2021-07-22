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
        public Usuarios usuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            NegocioColores NegocioColores = new Negocio.NegocioColores();
            NegocioCategorias NegocioCategorias = new Negocio.NegocioCategorias();
            NegocioEstampado NegocioEstampado = new Negocio.NegocioEstampado();
            NegocioTalles NegocioTalles = new Negocio.NegocioTalles();
           
            var listaproducto = (List<Producto>)Application["ListadosProductos"];
            Carrito carrito = new Carrito();

            usuario = (Usuarios)Application["UsuarioOnLine"];
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

        protected void buttonEliminar_Click(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                //List<ItemCarrito> carrito = (List<ItemCarrito>)Session["listaCarrito"];
                //ItemCarrito elim = carrito.Find(x => x.ID.ToString() == argument);
                //carrito.Remove(elim);
                //Session.Add("listadosProductos", carrito);
                //Repetidor.DataSource = null;
                //Repetidor.DataSource = carrito;
                //Repetidor.DataBind();
            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx");
            }
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
    }
}