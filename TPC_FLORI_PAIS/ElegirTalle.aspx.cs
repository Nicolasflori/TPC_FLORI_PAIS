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
            int id = int.Parse(Request.QueryString["id"]);
            Negocio.NegocioColores NegocioColores = new Negocio.NegocioColores();
            Negocio.NegocioCategorias NegocioCategorias = new Negocio.NegocioCategorias();
            Negocio.NegocioEstampado NegocioEstampado = new Negocio.NegocioEstampado();


            List<ProductoPreCargado> listado = (List<ProductoPreCargado>)Session["listadoProductoPreCargado"];
            ProductoPreCargado seleccionado = listado.Find(x => x.ID == id);

            int varcategoria = seleccionado.IDCategoria;
            lblCategoria.Text = NegocioCategorias.descripcionxid(varcategoria);
            int varestamapdo = seleccionado.IDEstampado;
            LblEstampado.Text = NegocioEstampado.descripcionxid(varestamapdo);
            int varcolor = seleccionado.IDColor;

            //String imagen = "recursos" + "\" + lblCategoria.Text + "\ " + varcolor + ".jpg";
            // Imagen.ImageUrl = imagen;
            //decimal aux = seleccionado.Precio;
            //LblPrecio.Text = aux.ToString();

        }
    }
}