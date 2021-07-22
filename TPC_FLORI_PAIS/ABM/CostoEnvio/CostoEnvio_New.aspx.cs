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
    public partial class CostoEnvio_New : System.Web.UI.Page
    {
        NegocioCostoEnvio negocioCostoEnvio = new NegocioCostoEnvio();
        protected void Page_Load(object sender, EventArgs e)
        {
            Permisos permisos = new Permisos();
            if (permisos.validarPermiso() == true)
            {

            }
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Dominio.CostoEnvio costoEnvio = new Dominio.CostoEnvio()
            {
                
                Zona = int.Parse(txt_Zona.Text),
                Precio = txt_Precio.Text.Length
            };
            negocioCostoEnvio.agregar(costoEnvio);

            Response.Redirect("CostoEnvio.aspx");
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("CostoEnvio.aspx");
        }
    }
}