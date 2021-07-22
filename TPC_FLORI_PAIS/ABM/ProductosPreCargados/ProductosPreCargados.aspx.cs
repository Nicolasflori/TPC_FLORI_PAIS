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
    public partial class ProductosPreCargados : System.Web.UI.Page
    { NegocioProductoPreCargado NegocioProductoPreCargado = new NegocioProductoPreCargado();

        protected void Page_Load(object sender, EventArgs e)
        {
            Permisos permisos = new Permisos();
            if (permisos.validarPermiso() == true)
            {
                if (!IsPostBack)
                {
                    CargarProductosPreCargados();
                }
            }
        }

        protected void CargarProductosPreCargados()
        {
            grid_ProductosPreCargados.Columns[1].HeaderText = "Color";
            grid_ProductosPreCargados.Columns[2].HeaderText = "Categoria";
            grid_ProductosPreCargados.Columns[3].HeaderText = "Estampado";
            grid_ProductosPreCargados.DataSource = DataSetEstampados();
            grid_ProductosPreCargados.DataBind();

        }
        protected List<ProductoPreCargado> DataSetEstampados()
        {
            return NegocioProductoPreCargado.listar();

        }
        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            CargarProductosPreCargados();
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductosPreCargados_New.aspx");
        }

        protected void grid_ProductosPreCargados_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grid_ProductosPreCargados.DataSource = DataSetEstampados();
            this.grid_ProductosPreCargados.PageIndex = e.NewPageIndex;
            this.grid_ProductosPreCargados.DataBind();
        }

        protected void grid_ProductosPreCargados_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            NegocioColores negocioColores = new NegocioColores();
            NegocioEstampado negocioEstampado = new NegocioEstampado();
            NegocioCategorias negocioCategorias = new NegocioCategorias();


            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                 e.Row.Cells[1].Text = negocioColores.descripcionxid(int.Parse(e.Row.Cells[1].Text)) ;
                e.Row.Cells[2].Text = negocioCategorias.descripcionxid(int.Parse(e.Row.Cells[2].Text));
                e.Row.Cells[3].Text = negocioEstampado.descripcionxid(int.Parse(e.Row.Cells[3].Text));
                /// e.Row.Cells[2].Text = "../../recursos/Remera/" + negocioColores.descripcionxid(int.Parse(e.Row.Cells[2].Text)) + ".jpg";

            }


        }
    }
}