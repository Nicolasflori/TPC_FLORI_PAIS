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
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Talle> listaTalles;
            int id = int.Parse(Request.QueryString["id"]);
            Negocio.NegocioColores NegocioColores = new NegocioColores();
            Negocio.NegocioCategorias NegocioCategorias = new NegocioCategorias();
            Negocio.NegocioEstampado NegocioEstampado = new NegocioEstampado();
            NegocioTalles NegocioTalles = new NegocioTalles();

            List<ProductoPreCargado> listado = (List<ProductoPreCargado>)Session["listadoProductoPreCargado"];
            ProductoPreCargado seleccionado = listado.Find(x => x.ID == id);

            int varcategoria = seleccionado.IDCategoria;
            lblCategoria.Text = NegocioCategorias.descripcionxid(varcategoria);
            int varestamapdo = seleccionado.IDEstampado;
            LblEstampado.Text = NegocioEstampado.descripcionxid(varestamapdo);
            int varcolor = seleccionado.IDColor;

            String imagen = "../recursos/Remera/" + varcolor + ".jpg";
             Imagen.ImageUrl = imagen;
            decimal aux = NegocioCategorias.getprecioxid(seleccionado.ID) + NegocioEstampado.getprecioxid(seleccionado.ID);;
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
    }
}