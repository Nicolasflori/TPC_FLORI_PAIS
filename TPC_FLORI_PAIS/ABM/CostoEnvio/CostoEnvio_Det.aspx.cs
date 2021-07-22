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
    public partial class CostoEnvio_Det : System.Web.UI.Page
    {
        NegocioCostoEnvio negocioCostoEnvio = new NegocioCostoEnvio();
        public List<Dominio.CostoEnvio> listaCostosEnvio;

        protected void Page_Load(object sender, EventArgs e)
        {

            Permisos permisos = new Permisos();
            if (permisos.validarPermiso() == true)
            {
                if (!IsPostBack)
                {
                    txt_Zona.Text = negocioCostoEnvio.zonaxid(int.Parse(Request.QueryString["id"])).ToString();
                    listaCostosEnvio = negocioCostoEnvio.listar();
                    Dominio.CostoEnvio seleccionado = listaCostosEnvio.Find(x => x.ID == (int.Parse(Request.QueryString["id"])));
                    txt_Precio.Text = seleccionado.Precio.ToString();
                }
            }
        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            int idCostoDeEnvio = int.Parse(Request.QueryString["id"]);
            Dominio.CostoEnvio costoEnvio = new Dominio.CostoEnvio()
            {
                ID = idCostoDeEnvio,
                Zona = int.Parse(txt_Zona.Text),
                Precio = decimal.Parse(txt_Precio.Text)
            };
            negocioCostoEnvio.modificar(costoEnvio);

            Response.Redirect("CostoEnvio.aspx");
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int idCostoDeEnvio = int.Parse(Request.QueryString["id"]);
            negocioCostoEnvio.eliminar(idCostoDeEnvio);

            Response.Redirect("CostoEnvio.aspx");
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("CostoEnvio.aspx");
        }
    }
}