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
    public partial class FinalizarCompra : System.Web.UI.Page
    {
        List<Producto> listaproducto = new List<Producto>();

        protected void Page_Load(object sender, EventArgs e)
        {
            listaproducto = (List<Producto>)Application["ListadosProductos"];
            var usuario = new Usuarios();
            usuario = (Usuarios)Session["usuario"];


            if (listaproducto != null)
            {
                decimal precioTotalProductos = 0;
                foreach (Producto producto in listaproducto)
                {
                    precioTotalProductos += producto.PrecioxProducto;
                }

                //Direccion direccion = NegocioDireccion.buscarxid(usuario.IDDireccion);
                //Provincia provincia = NegocioProvincia.buscarxid(direccion.IDProvincia); ;
                //CostosDeEnvio costoEnvio = NegocioCostosDeEnvio.buscarxid(provincia.IDCostoEnvio);

                //var carrito = new Carrito()
                //{
                //    IDUsuario = usuario.ID,
                //    Items = listaproducto,
                //    SubTotalProductos = precioTotalProductos,
                //    CostoDeEnvio = costoEnvio.Precio,
                //    Total = precioTotalProductos + costoEnvio.Precio,
                //    Estado = "Borrador",
                //    FormaPago = null,
                //    Fecha = null,
                //    FechaEntrega = null
                //};





            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void btn_Comprar_Click(object sender, EventArgs e)
        {

        }
    }
}