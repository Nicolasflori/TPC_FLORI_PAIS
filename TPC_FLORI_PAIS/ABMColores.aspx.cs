using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio; 
namespace TPC_FLORI_PAIS
{
    public partial class ABMColores : System.Web.UI.Page
    {   Color color = new Color();
        NegocioColores NegocioColores = new Negocio.NegocioColores();
            List<Color> listaColores = new List<Color>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            listaColores = NegocioColores.listar();
            GridViewColores.DataSource = listaColores;
            GridViewColores.DataBind();

        }

        protected void Modificar_Click(object sender, EventArgs e)
        {
            var argument = ((Button)sender).CommandArgument;
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            theDiv.Visible = true;
        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {
           string descripcion = Request.Form.Get("descripcion");
            color.Descripcion = descripcion;
            NegocioColores.agregar(color);
        }
    }
}