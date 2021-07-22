using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
namespace TPC_FLORI_PAIS.ABM.Estampados
{
    public partial class Estampados : System.Web.UI.Page
    {
        NegocioEstampado NegocioEstampados = new Negocio.NegocioEstampado();

        protected void Page_Load(object sender, EventArgs e)
        {
            Permisos permisos = new Permisos();
            if (permisos.validarPermiso() == true)
            {
                if (!IsPostBack)
                {
                    CargarEstampados();
                }
            }
        }

        protected void CargarEstampados()
        {
            grid_Estampados.DataSource = DataSetEstampados();
            grid_Estampados.DataBind();

        }
        protected List<Estampado> DataSetEstampados()
        {
            return NegocioEstampados.listar();
        }
        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            CargarEstampados();
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estampados_New.aspx");
        }

        protected void grid_Estampados_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grid_Estampados.DataSource = DataSetEstampados();
            this.grid_Estampados.PageIndex = e.NewPageIndex;
            this.grid_Estampados.DataBind();
        }
    }
}