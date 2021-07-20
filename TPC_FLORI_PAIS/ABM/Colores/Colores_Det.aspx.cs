using System;
using Dominio;
using Negocio;

namespace TPC_FLORI_PAIS.ABM.Colores
{
    public partial class Colores_Det : System.Web.UI.Page
    {
        NegocioColores NegocioColores = new Negocio.NegocioColores();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txt_Descripcion.Text = NegocioColores.descripcionxid(int.Parse(Request.QueryString["id"]));
            }
        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            int idColor = int.Parse(Request.QueryString["id"]);
            Color color = new Color() {
                ID=idColor,
                Descripcion= txt_Descripcion.Text
            };
            NegocioColores.modificar(color);

            Response.Redirect("Colores.aspx");
        }

      

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Colores.aspx");
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int idColor = int.Parse(Request.QueryString["id"]);
            NegocioColores.eliminar(idColor);

            Response.Redirect("Colores.aspx");
        }

       
    }
}