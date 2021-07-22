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
    public partial class Estampados_New : System.Web.UI.Page
    {
        NegocioEstampado NegocioEstampados = new Negocio.NegocioEstampado();
        protected void Page_Load(object sender, EventArgs e)
        {
            Permisos permisos = new Permisos();
            if (permisos.validarPermiso() == true)
            {

            }
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Estampado estampado = new Estampado()
            {
                Descripcion = txt_Descripcion.Text,
                Imagen = txt_Imagen.Text,
                Precio = txt_Precio.Text.Length
            };

            NegocioEstampados.agregar(estampado);

            Response.Redirect("CostoEnvio.aspx");
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("CostoEnvio.aspx");
        }
    }
}