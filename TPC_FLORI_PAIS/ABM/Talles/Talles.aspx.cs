using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
namespace TPC_FLORI_PAIS.ABM.Talles
{
    public partial class Talles : System.Web.UI.Page
    {
        NegocioTalles negocioTalles = new NegocioTalles();
        protected void Page_Load(object sender, EventArgs e)
        {
            Permisos permisos = new Permisos();
            if (permisos.validarPermiso() == true)
            {
                if (!IsPostBack)
                {
                    CargarTalles();
                }
            }
        }

        protected void CargarTalles()
        {
            grid_Talles.DataSource = DataSetTalles();
            grid_Talles.DataBind();

        }

        protected List<Talle> DataSetTalles()
        {
            return negocioTalles.listar();
        }
        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            CargarTalles();
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Talles_New.aspx");
        }

        protected void grid_Colores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grid_Talles.DataSource = DataSetTalles();
            this.grid_Talles.PageIndex = e.NewPageIndex;
            this.grid_Talles.DataBind();
        }
    }
}