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
        public List<ItemCarrito> carrito;

        public ItemCarrito elemento;

        protected void Page_Load(object sender, EventArgs e)
        {
            carrito = (List<ItemCarrito>)Session["listaCarrito"];
            elemento = new ItemCarrito();

            if (carrito == null)
                carrito = new List<ItemCarrito>();
            if (!IsPostBack)
            {
                
                        List<Producto> listadoOriginal = (List<Producto>)Session["ListadoProductos"];
                        elemento.Articulos = listadoOriginal.Find(x => x.ID.ToString() == Request.QueryString["id"]);
                        carrito.Add(elemento);
                    }
                }
                Repetidor.DataSource = carrito;

                Repetidor.DataBind();
            }
            Session.Add("ListaCarrito", carrito);
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}