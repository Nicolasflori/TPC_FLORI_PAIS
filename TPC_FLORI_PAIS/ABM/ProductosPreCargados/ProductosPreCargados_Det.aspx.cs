using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
namespace TPC_FLORI_PAIS.ABM.ProductosPreCargados
{
    public partial class ProductosPreCargados_Det : System.Web.UI.Page
    {
        NegocioCategorias negocioCategorias = new NegocioCategorias();
        NegocioColores negocioColores = new NegocioColores();
        NegocioEstampado negocioEstampado = new NegocioEstampado();
        NegocioProductoPreCargado negocioProductoPreCargado = new NegocioProductoPreCargado();

        List<Categoria> listaCategoria = new List<Categoria>();
        List<Color> listaColores = new List<Color>();
        List<Estampado> listaEstampado = new List<Estampado>();
        List<ProductoPreCargado> listaProductoPreCargado = new List<ProductoPreCargado>();
        
        protected void Page_Load(object sender, EventArgs e)
        {

            Permisos permisos = new Permisos();
            if (permisos.validarPermiso() == true)
            {
                if (!IsPostBack)
                {
                    listaColores = negocioColores.listar();

                    DropDownListColores.DataValueField = "ID";
                    DropDownListColores.DataTextField = "Descripcion";
                    DropDownListColores.DataSource = listaColores;
                    DropDownListColores.DataBind();

                    listaEstampado = negocioEstampado.listar();

                    DropDownListEstampados.DataValueField = "ID";
                    DropDownListEstampados.DataTextField = "Descripcion";
                    DropDownListEstampados.DataSource = listaEstampado;
                    DropDownListEstampados.DataBind();

                    listaCategoria = negocioCategorias.listar();

                    DropDownListCategoria.DataValueField = "ID";
                    DropDownListCategoria.DataTextField = "Descripcion";
                    DropDownListCategoria.DataSource = listaCategoria;
                    DropDownListCategoria.DataBind();

                    int idProductoPreCargado = int.Parse(Request.QueryString["id"]);

                    listaProductoPreCargado = negocioProductoPreCargado.listar();
                    ProductoPreCargado seleccionado = listaProductoPreCargado.Find(x => x.ID == idProductoPreCargado);
                    DropDownListColores.SelectedValue = seleccionado.IDColor.ToString();
                    DropDownListCategoria.SelectedValue = seleccionado.IDCategoria.ToString();
                    DropDownListEstampados.SelectedValue = seleccionado.IDEstampado.ToString();

                }
            }
        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            int idproductoPreCargado = int.Parse(Request.QueryString["id"]);
            ProductoPreCargado productoPreCargado = new ProductoPreCargado()
            {
                ID = idproductoPreCargado,
                IDColor = int.Parse(DropDownListColores.SelectedValue),
                IDCategoria = int.Parse(DropDownListCategoria.SelectedValue),
                IDEstampado = int.Parse(DropDownListEstampados.SelectedValue)

            };

            negocioProductoPreCargado.modificar(productoPreCargado);

            Response.Redirect("ProductosPreCargados.aspx");

        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int idProductoPreCargado = int.Parse(Request.QueryString["id"]);
            negocioProductoPreCargado.eliminar(idProductoPreCargado);

            Response.Redirect("ProductosPreCargados.aspx");
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductosPreCargados.aspx");
        }
    }
}