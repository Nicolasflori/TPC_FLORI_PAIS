using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TPC_FLORI_PAIS.ABM.Colores
{
    public partial class Colores_New : System.Web.UI.Page
    {
        NegocioColores NegocioColores = new Negocio.NegocioColores();

        protected void Page_Load(object sender, EventArgs e)
        {
            Permisos permisos = new Permisos();
            if(permisos.validarPermiso() == true)
            {

            }
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Color color = new Color()
            {
                Descripcion = txt_Descripcion.Text
            };

            NegocioColores.agregar(color);

            Response.Redirect("Colores.aspx");
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Colores.aspx");
        }
    }
}