using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Common;
using Negocio;
using Dominio;

namespace TPC_FLORI_PAIS.ABM.Colores
{
    public partial class Colores : System.Web.UI.Page
    {
        NegocioColores NegocioColores = new Negocio.NegocioColores();

        protected void Page_Load(object sender, EventArgs e)
        {
            Permisos permisos = new Permisos();
            if (permisos.validarPermiso() == true)
            {
                if (!IsPostBack)
                {
                    CargarColores();
                }
            }
        }

        protected void CargarColores()
        {
            grid_Colores.DataSource = DataSetColores();
            grid_Colores.DataBind();

        }

        protected List<Color> DataSetColores()
        {
            return NegocioColores.listar();
        }

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            CargarColores();
        }

        protected void grid_Colores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grid_Colores.DataSource = DataSetColores();
            this.grid_Colores.PageIndex = e.NewPageIndex;
            this.grid_Colores.DataBind();
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Colores_New.aspx");
        }
    }
}