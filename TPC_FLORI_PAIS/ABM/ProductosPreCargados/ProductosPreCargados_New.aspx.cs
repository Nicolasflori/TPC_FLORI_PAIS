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
    public partial class ProductosPreCargados_New : System.Web.UI.Page
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
                listaColores = negocioColores.listar();

                ListItem b;
                foreach (Color item in listaColores)
                {
                    b = new ListItem(item.Descripcion, item.ID.ToString());
                    DropDownListColores.Items.Add(b);
                }


                listaCategoria = negocioCategorias.listar();
                ListItem a;
                foreach (Categoria item in listaCategoria)
                {
                    a = new ListItem(item.Descripcion, item.ID.ToString());
                    DropDownListCategoria.Items.Add(a);
                }


                listaEstampado = negocioEstampado.listar();

                ListItem c;
                foreach (Estampado item in listaEstampado)
                {
                    c = new ListItem(item.Descripcion, item.ID.ToString());
                    DropDownListEstampados.Items.Add(c);
                }
            }
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {

            ProductoPreCargado productoPreCargado = new ProductoPreCargado()           
            {
                
                IDColor = DropDownListColores.SelectedIndex + 1,
                IDCategoria = DropDownListCategoria.SelectedIndex + 1,
                IDEstampado = DropDownListEstampados.SelectedIndex + 1

            };

            negocioProductoPreCargado.agregar(productoPreCargado);

            Response.Redirect("ProductosPreCargados.aspx");
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductosPreCargados.aspx");
        }
    }
}