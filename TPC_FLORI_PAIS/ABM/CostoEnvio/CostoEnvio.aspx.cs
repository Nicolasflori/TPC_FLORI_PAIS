using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_FLORI_PAIS.ABM.CostoEnvio
{
    public partial class CostoEnvio : System.Web.UI.Page
    {
        NegocioCostoEnvio NegocioCostoEnvio = new Negocio.NegocioCostoEnvio();

        protected void Page_Load(object sender, EventArgs e)
        {
            Permisos permisos = new Permisos();
            if (permisos.validarPermiso() == true)
            {
                if (!IsPostBack)
                {
                    CargarCostoEnvio();
                }
            }
        }

        protected void CargarCostoEnvio()
        {
            grid_CostoEnvio.DataSource = DataSetCostoEnvio();
            grid_CostoEnvio.DataBind();

        }
        protected List<Dominio.CostoEnvio> DataSetCostoEnvio()
        {
            return NegocioCostoEnvio.listar();
        }
        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            CargarCostoEnvio();
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CostoEnvio_New.aspx");
        }

        protected void grid_CostoEnvio_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grid_CostoEnvio.DataSource = DataSetCostoEnvio();
            this.grid_CostoEnvio.PageIndex = e.NewPageIndex;
            this.grid_CostoEnvio.DataBind();
        }
    }
}