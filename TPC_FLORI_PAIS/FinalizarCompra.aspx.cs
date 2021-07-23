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
        NegocioColores NegocioColores = new NegocioColores();
        NegocioCategorias NegocioCategorias = new NegocioCategorias();
        NegocioEstampado NegocioEstampado = new NegocioEstampado();
        NegocioTalles NegocioTalles = new NegocioTalles();
        NegocioCarrito NegocioCarrito = new NegocioCarrito();
        NegocioDireccion NegocioDireccion = new NegocioDireccion();
        NegocioCostoEnvio NegocioCostoEnvio = new NegocioCostoEnvio();
        NegocioProvincia NegocioProvincia = new NegocioProvincia();
        Carrito carrito = new Carrito();

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
                    producto.Categoria = NegocioCategorias.descripcionxid(producto.IDCategoria);
                    producto.Color = NegocioColores.descripcionxid(producto.IDColor);
                    producto.Estampado = NegocioEstampado.descripcionxid(producto.IDEstampado);
                    producto.Talle = NegocioTalles.descripcionxid(producto.IDTalle);
                }

                //Direccion direccion = negocioDireccion.buscarxid(usuario.IDDireccion);
                //var costoEnvio = negocioCostoEnvio.buscarxid(direccion.IDProvincia);
                //var costoEnvio = negocioCostoEnvio.buscarxid(direccion.IDProvincia);

                Direccion direccion = NegocioDireccion.buscarxid(usuario.IDDireccion);
                Provincia provincia = NegocioProvincia.buscarxid(direccion.IDProvincia);
                CostoEnvio costoEnvio = NegocioCostoEnvio.buscarxid(provincia.IDCostoEnvio);


                carrito = new Carrito()
                {
                    IDUsuario = usuario.ID,
                    Items = listaproducto,
                    SubTotalProductos = precioTotalProductos,
                    CostoDeEnvio = costoEnvio.Precio,
                    Total = precioTotalProductos + costoEnvio.Precio,
                    Estado = "Borrador",
                    FormaPago = ddMetodoPago.Text,

                    //Fecha = null,
                    //FechaEntrega = null
                };

                // Mostrar listado
                Repetidor.DataSource = carrito.Items;
                Repetidor.DataBind();

                c_FechaEntrega.SelectedDate = DateTime.Today.AddDays(3);
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void btn_Comprar_Click(object sender, EventArgs e)
        {
            carrito.FormaPago = ddMetodoPago.Text;
            carrito.FechaEntrega = c_FechaEntrega.SelectedDate;

            // Cargo la cabecera del pedido
            var idCarrito = NegocioCarrito.agregar(carrito);

            // Cargo el detalle del pedido
            foreach (Producto item in carrito.Items)
            {
                item.IDCarrito = idCarrito;
                NegocioCarrito.agregarDet(item);
            }

            // Cartel de confirmacion de compra
            var page = HttpContext.Current.CurrentHandler as Page;
            ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "COMPRA REALIZADA CORRECTAMENTE. RECIBIRA UN MAIL CON EL DETALLE DE LA COMPRA!" + "');window.location ='" + "Default.aspx" + "';", true);

            // Enviar Mail

            // Borrar Sesiones
            Application["ListadosProductos"] = null;

            // Redireccionar
            //Response.Redirect("Default.aspx");
        }

        protected void Atras_Click(object sender, EventArgs e)
        {
            Response.Redirect("CarritoDeCompra.aspx");
        }
    }
}