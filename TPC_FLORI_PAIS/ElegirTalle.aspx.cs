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
    public partial class ElegirTalle : System.Web.UI.Page
    {
        public List<ProductoPreCargado> listaProductoPreCargado;
        private Producto producto { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Talle> listaTalles = new List<Talle>();
            producto = new Producto();

            if (!IsPostBack)
            {
                int idproductoprecargado = int.Parse(Request.QueryString["id"]);
                var NegocioColores = new NegocioColores();
                var NegocioCategorias = new NegocioCategorias();
                var NegocioEstampado = new NegocioEstampado();
                var NegocioTalles = new NegocioTalles();
                var NegocioProductoPreCargado = new NegocioProductoPreCargado();

                listaProductoPreCargado = NegocioProductoPreCargado.listar();
                ProductoPreCargado seleccionado = listaProductoPreCargado.Find(x => x.ID == idproductoprecargado);

                lblCategoria.Text = NegocioCategorias.descripcionxid(seleccionado.IDCategoria);

                LblEstampado.Text = NegocioEstampado.descripcionxid(seleccionado.IDEstampado);

                String imagenfondo = "../recursos/Remera/" + NegocioColores.descripcionxid(seleccionado.IDColor) + ".jpg";
                Imagenfondo.ImageUrl = imagenfondo;
                String imagenestamapado = "../recursos/estampado/" + NegocioEstampado.imagenxid(seleccionado.IDEstampado);
                Imageestampado.ImageUrl = imagenestamapado;
                decimal aux = NegocioCategorias.getprecioxid(seleccionado.IDCategoria) + NegocioEstampado.getprecioxid(seleccionado.IDEstampado);
                LblPrecio.Text = aux.ToString();

                listaTalles = NegocioTalles.listar();

                ddListaTalles.DataSource = listaTalles;
                ddListaTalles.DataValueField = "ID";
                ddListaTalles.DataTextField = "Descripcion";
                ddListaTalles.DataBind();

               

                producto.IDCategoria = seleccionado.IDCategoria;
                producto.IDColor = seleccionado.IDColor;
                producto.IDEstampado = seleccionado.IDEstampado;
                producto.Precio = NegocioCategorias.getprecioxid(seleccionado.IDCategoria) + NegocioEstampado.getprecioxid(seleccionado.IDEstampado);

                Application["ProductoSeleccionado"] = producto;
            }
        }

        protected void buttonAgregarCarrito_Click(object sender, EventArgs e)
        {
            var lista = new List<Producto>();
            var producto = (Producto)Application["ProductoSeleccionado"];
            producto.IDTalle = int.Parse(ddListaTalles.SelectedValue);
            producto.Cantidad = int.Parse(TextBox1.Text);
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