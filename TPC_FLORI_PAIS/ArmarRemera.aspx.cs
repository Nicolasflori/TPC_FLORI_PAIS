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
    public partial class ArmarRemera : System.Web.UI.Page
    {
        private Producto producto { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Color> listaColores = new List<Color>();
            List<Estampado> listaEstampados = new List<Estampado>();
            List<Talle> listaTalles = new List<Talle>();
            List<Producto> listaProductos = new List<Producto>();
            
            var NegocioColores = new NegocioColores();
            var NegocioCategorias = new NegocioCategorias();
            var NegocioEstampado = new NegocioEstampado();
            var NegocioTalles = new NegocioTalles();

            

            if (!IsPostBack)
            {
                producto = new Producto();

                producto.IDCategoria = 1;
                producto.IDColor = 1;
                producto.IDEstampado = 1;

                producto.Color = NegocioColores.descripcionxid(producto.IDColor);
                producto.Estampado = NegocioEstampado.descripcionxid(producto.IDEstampado);
                producto.Categoria = NegocioCategorias.descripcionxid(producto.IDCategoria) + " Estampada " + NegocioEstampado.descripcionxid(producto.IDEstampado);
                producto.ImagenColor = "../recursos/Remera/" + NegocioColores.descripcionxid(producto.IDColor) + ".jpg";
                producto.ImagenEstampado = "../recursos/estampado/" + NegocioEstampado.imagenxid(producto.IDEstampado); 

                String imagenfondo = producto.ImagenColor;
                Imagenfondo.ImageUrl = imagenfondo;
                String imagenestamapado = producto.ImagenEstampado;
                Imageestampado.ImageUrl = imagenestamapado;

                listaColores = NegocioColores.listar();

                ddListaColores.DataValueField = "ID";
                ddListaColores.DataTextField = "Descripcion";
                ddListaColores.DataSource = listaColores;
                ddListaColores.DataBind();

                listaEstampados = NegocioEstampado.listar();

                ddListaEstampados.DataValueField = "ID";
                ddListaEstampados.DataTextField = "Descripcion";
                ddListaEstampados.DataSource = listaEstampados;
                ddListaEstampados.DataBind();

                listaTalles = NegocioTalles.listar();

                ddListaTalles.DataValueField = "ID";
                ddListaTalles.DataTextField = "Descripcion";
                ddListaTalles.DataSource = listaTalles;
                ddListaTalles.DataBind();

                Application["ProductoArmado"] = producto;

            }
        }

        protected void ddListaColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            var producto = (Producto)Application["ProductoArmado"];
            producto.IDColor = int.Parse(ddListaColores.SelectedValue);
            producto.ImagenColor = "../recursos/Remera/" + ddListaColores.SelectedItem.Text + ".jpg";
            String imagenfondo = producto.ImagenColor;
            Imagenfondo.ImageUrl = imagenfondo;
        }

        protected void ddListaEstampados_SelectedIndexChanged(object sender, EventArgs e)
        {
            var producto = (Producto)Application["ProductoArmado"];
            producto.IDEstampado = int.Parse(ddListaEstampados.SelectedValue);
            producto.ImagenEstampado = "../recursos/estampado/" + ddListaEstampados.SelectedValue + ".png";
            String imagenestamapado = producto.ImagenEstampado;
            Imageestampado.ImageUrl = imagenestamapado;
        }

        protected void AgregarCarrito_Click(object sender, EventArgs e)
        {
            var lista = new List<Producto>();
            var producto = (Producto)Application["ProductoArmado"];
            var NegocioCategorias = new NegocioCategorias();
            var NegocioEstampado = new NegocioEstampado();

            producto.IDTalle = int.Parse(ddListaTalles.SelectedValue);
            producto.Cantidad = int.Parse(TextBox1.Text);
            producto.Precio = NegocioCategorias.getprecioxid(producto.IDCategoria) + NegocioEstampado.getprecioxid(producto.IDEstampado);
            producto.PrecioxProducto = producto.Cantidad * producto.Precio;
            lista.Add(producto);

            var productosCargados = (List<Producto>)Application["ListadosProductos"];

            if (productosCargados == null)
            {
                Application["ListadosProductos"] = lista;
            }
            else
            {
                productosCargados.Add(producto);
                Application["ListadosProductos"] = productosCargados;
            }

            Response.Redirect("CarritoDeCompra.aspx");
        }
        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }

}