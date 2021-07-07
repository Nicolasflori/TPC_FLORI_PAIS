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

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Talle> listaTalles= (List<Talle>)Session["ListadoTalles"];
            int id = int.Parse(Request.QueryString["id"]);
            Negocio.NegocioColores NegocioColores = new NegocioColores();
            Negocio.NegocioCategorias NegocioCategorias = new NegocioCategorias();
            Negocio.NegocioEstampado NegocioEstampado = new NegocioEstampado();
            NegocioTalles NegocioTalles = new NegocioTalles();
            NegocioProductoPreCargado NegocioProductoPreCargado = new NegocioProductoPreCargado();

            listaProductoPreCargado = NegocioProductoPreCargado.listar();
            ProductoPreCargado seleccionado = listaProductoPreCargado.Find(x => x.ID == id);

           
            lblCategoria.Text = NegocioCategorias.descripcionxid(seleccionado.IDCategoria);
            
            LblEstampado.Text = NegocioEstampado.descripcionxid(seleccionado.IDEstampado);
            
            string colorprenda = NegocioColores.descripcionxid(seleccionado.IDColor);
            string varEstampado= NegocioEstampado.descripcionxid(seleccionado.IDEstampado);

            String imagenfondo = "../recursos/Remera/" + colorprenda + ".jpg";
            Imagenfondo.ImageUrl = imagenfondo;
            String imagenestamapado = "../recursos/estampado/" + varEstampado;
            Imageestampado.ImageUrl = imagenestamapado;
            decimal aux = NegocioCategorias.getprecioxid(seleccionado.ID) + NegocioEstampado.getprecioxid(seleccionado.ID);
            LblPrecio.Text = aux.ToString();

            listaTalles = NegocioTalles.listar();
            Session.Add("listadoProductoPreCargado", listaTalles);

            ListItem i;
            foreach (Talle item in listaTalles)
            {
                i = new ListItem(item.Descripcion, item.ID.ToString());
                ddListaTalles.Items.Add(i);
            }

            Producto producto = new Producto();
            producto.IDCategoria = seleccionado.IDCategoria;
            producto.IDColor = seleccionado.IDColor;
            producto.IDTalle = ddListaTalles.SelectedIndex;
            producto.IDEstampado = seleccionado.IDEstampado;
            producto.Precio = NegocioCategorias.getprecioxid(seleccionado.ID) + NegocioEstampado.getprecioxid(seleccionado.ID);

            Session.Add("ListadoProductos", producto);
        }
        protected void buttonAgregarCarrito_Click(object sender, EventArgs e)
        {
            Response.Redirect("CarritoDeCompra.aspx");
        }
    }
}