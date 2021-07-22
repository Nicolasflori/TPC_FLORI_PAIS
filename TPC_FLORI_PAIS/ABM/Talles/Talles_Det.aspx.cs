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
    public partial class Talles_Det : System.Web.UI.Page
    {
        NegocioTalles negocioTalles = new NegocioTalles();

        protected void Page_Load(object sender, EventArgs e)
        {
            Permisos permisos = new Permisos();
            if (permisos.validarPermiso() == true)
            {
                if (!IsPostBack)
                {
                    txt_Descripcion.Text = negocioTalles.descripcionxid2(Request.QueryString["id"]);
                }
            }
        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            int idTalle = int.Parse(Request.QueryString["id"]);
            Talle talle = new Talle()
            {
                ID = idTalle,
                Descripcion = txt_Descripcion.Text
            };
            negocioTalles.modificar(talle);

            Response.Redirect("Talles.aspx");
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int idTalle = int.Parse(Request.QueryString["id"]);
            negocioTalles.eliminar(idTalle);

            Response.Redirect("Talles.aspx");
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Talles.aspx");
        }
    }
}