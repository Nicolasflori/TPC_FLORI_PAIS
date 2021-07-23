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
        NegocioUsuarios NegocioUsuarios = new NegocioUsuarios();
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

                Direccion direccion = NegocioDireccion.buscarxid(usuario.IDDireccion);
                //Provincia provincia = NegocioProvincia.buscarxid(direccion.IDProvincia);
                //CostoEnvio costoEnvio = NegocioCostoEnvio.buscarxid(provincia.IDCostoEnvio);

                carrito = new Carrito()
                {
                    IDUsuario = usuario.ID,
                    Items = listaproducto,
                    SubTotalProductos = precioTotalProductos,
                    //CostoDeEnvio = costoEnvio.Precio,
                    //Total = precioTotalProductos + costoEnvio.Precio,
                    Total = precioTotalProductos + 405,
                    Estado = "Borrador",
                    FormaPago = ddMetodoPago.Text,

                    //Fecha = null,
                    //FechaEntrega = null
                };

                // Mostrar listado
                Repetidor.DataSource = carrito.Items;
                Repetidor.DataBind();

            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void btn_Comprar_Click(object sender, EventArgs e)
        {
            carrito.FormaPago = ddMetodoPago.Text;

            // Cargo la cabecera del pedido
            var idCarrito = NegocioCarrito.agregar(carrito);

            // Cargo el detalle del pedido
            foreach (Producto item in carrito.Items)
            {
                item.IDCarrito = idCarrito;
                NegocioCarrito.agregarDet(item);
            }

            NegocioUsuarios NegocioUsuarios = new NegocioUsuarios();

            // Enviar Mail
            string Asunto = "Remeras FLORIPAIS - Compra Realizada!";
            string Cuerpo = "Estás recibiendo este e-mail porque hiciste una compra en Remeras FloriPais. \n\n" +
                            "Muchas gracias por confiar en nosotros!. \n\n" +
                            "A continuacion el link para completar el pago: linkfalso.com \n\n" +
                            "Despues de que confirmemos el pago, el envío por correo Argentino demora entre 3 y 7 días hábiles. \n\n" +
                            "Por cualquier consulta comunicate con nosotros a traves de nuestras redes sociales: \n\n" +
                            "Instagram: @RemerasFloriPais\n" +
                            "Facebook: @RemerasFloriPais\n\n" +
                            "También podes contactarte respondiendo a este mail \n" +
                            "Atentamente \n" +
                            "Remeras FloriPais.";

            string Email = NegocioUsuarios.buscarMail(((Dominio.Usuarios)Session["usuario"]).ID);
            NegocioEmail emailService = new NegocioEmail();
            emailService.armarCorreo(Email, Asunto, Cuerpo);
            try
            {
                emailService.enviarEmail();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Cartel de confirmacion de compra
            var page = HttpContext.Current.CurrentHandler as Page;
            ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "Compra realizada correctamente. Recibirá un mail con el link de pago!" + "');window.location ='" + "Default.aspx" + "';", true);


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