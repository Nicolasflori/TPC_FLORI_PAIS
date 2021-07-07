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
    public partial class _Default : Page
    {
        public List<ProductoPreCargado> listaProductoPreCargado;
        public List<Color> listaColores;

        protected void Page_Load(object sender, EventArgs e)
        {
            NegocioProductoPreCargado NegocioProductoPreCargado = new NegocioProductoPreCargado();


            try
            {
                listaProductoPreCargado = NegocioProductoPreCargado.listar();
                Session.Add("listadoProductoPreCargado", listaProductoPreCargado);



            }
            catch (Exception ex)
            {
                Response.Redirect("Error.aspx");
            }
        }

        //protected void Unnamed_ServerClick(object sender, EventArgs e)
        //{
        //    NegocioProductoPreCargado negocio = new NegocioProductoPreCargado();
        //    ProductoPreCargado articulo = new ProductoPreCargado();
        //    lista = negocio.listar();
        //    lista = lista.FindAll(x => x.Nombre.ToUpper().Contains(Request["search"].ToUpper()));
        //    Session.Add("listadoArticulos", lista);
        //}
    }
}