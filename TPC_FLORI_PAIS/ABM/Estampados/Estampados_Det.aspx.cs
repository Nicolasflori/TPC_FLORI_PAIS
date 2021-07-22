using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
namespace TPC_FLORI_PAIS.ABM.Estampados
{
    public partial class Estampados_Det : System.Web.UI.Page
    {
        NegocioEstampado NegocioEstampados = new Negocio.NegocioEstampado();
        public List<Estampado> listaEstampados;
        protected void Page_Load(object sender, EventArgs e)
        {
            Permisos permisos = new Permisos();
            if (permisos.validarPermiso() == true)
            {
                if (!IsPostBack)
                {
                    txt_Descripcion.Text = NegocioEstampados.descripcionxid(int.Parse(Request.QueryString["id"]));
                    listaEstampados = NegocioEstampados.listar();
                    Estampado seleccionado = listaEstampados.Find(x => x.ID == (int.Parse(Request.QueryString["id"])));
                    txt_Imagen.Text = seleccionado.Imagen;
                    txt_Precio.Text = seleccionado.Precio.ToString();
                }
            }
        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            int idEstampados = int.Parse(Request.QueryString["id"]);
            Estampado Estampado = new Estampado()
            {
                ID = idEstampados,
                Descripcion = txt_Descripcion.Text,
                Imagen = txt_Imagen.Text,
                Precio = decimal.Parse(txt_Precio.Text)
            };
            NegocioEstampados.modificar(Estampado);

            Response.Redirect("Estampados.aspx");
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int idEstampados = int.Parse(Request.QueryString["id"]);
            NegocioEstampados.eliminar(idEstampados);

            Response.Redirect("Estampados.aspx");
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estampados.aspx");
        }
    }
}