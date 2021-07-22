using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_FLORI_PAIS.ABM.Talles
{
    public partial class Talles_New : System.Web.UI.Page
    {
        NegocioTalles negocioTalles = new NegocioTalles();

        protected void Page_Load(object sender, EventArgs e)
        {
            Permisos permisos = new Permisos();
            if (permisos.validarPermiso() == true)
            {

            }
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Talle talle = new Talle()
            {
                Descripcion = txt_Descripcion.Text
            };

            negocioTalles.agregar(talle);

            Response.Redirect("Talles.aspx");
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Talles.aspx");
        }
    }
}