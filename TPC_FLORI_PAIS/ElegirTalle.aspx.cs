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

            int idproductoprecargado = int.Parse(Request.QueryString["id"]);
            var NegocioColores = new NegocioColores();
            var NegocioCategorias = new NegocioCategorias();
            var NegocioEstampado = new NegocioEstampado();
            var NegocioTalles = new NegocioTalles();
            var NegocioProductoPreCargado = new NegocioProductoPreCargado();

            listaProductoPreCargado = NegocioProductoPreCargado.listar();
            ProductoPreCargado seleccionado = listaProductoPreCargado.Find(x => x.ID == idproductoprecargado);


            lblCategoria.Text = NegocioCategorias.descripcionxid(seleccionado.IDCategoria);

            LblEstampado.Text = NegocioEstampado.imagenxid(seleccionado.IDEstampado);

            string colorprenda = NegocioColores.descripcionxid(seleccionado.IDColor);
            string varEstampado = NegocioEstampado.imagenxid(seleccionado.IDEstampado);

            String imagenfondo = "../recursos/Remera/" + colorprenda + ".jpg";
            Imagenfondo.ImageUrl = imagenfondo;
            String imagenestamapado = "../recursos/estampado/" + varEstampado;
            Imageestampado.ImageUrl = imagenestamapado;
            decimal aux = NegocioCategorias.getprecioxid(seleccionado.ID) + NegocioEstampado.getprecioxid(seleccionado.ID);
            LblPrecio.Text = aux.ToString();

            listaTalles = NegocioTalles.listar();

            ListItem i;
            foreach (Talle item in listaTalles)
            {
                i = new ListItem(item.Descripcion, item.ID.ToString());
                ddListaTalles.Items.Add(i);
            }

            producto = new Producto();
            producto.IDCategoria = seleccionado.IDCategoria;
            producto.IDColor = seleccionado.IDColor;
           
            producto.IDEstampado = seleccionado.IDEstampado;
            producto.Precio = NegocioCategorias.getprecioxid(seleccionado.ID) + NegocioEstampado.getprecioxid(seleccionado.ID);
            
        }

        protected void buttonAgregarCarrito_Click(object sender, EventArgs e)
        {
            var lista = new List<Producto>();
            producto.IDTalle = ddListaTalles.SelectedIndex;
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
            var asdasd = (List<Producto>)Application["ListadosProductos"];

            Response.Redirect("CarritoDeCompra.aspx");
        }
    }
}