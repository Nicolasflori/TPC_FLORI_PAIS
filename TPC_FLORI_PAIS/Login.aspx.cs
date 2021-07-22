using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_FLORI_PAIS
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonIngresar_Click(object sender, EventArgs e)
        {

            var page = HttpContext.Current.CurrentHandler as Page;
            ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "Usuario logueado con Éxito!" + "');window.location ='" + "Default.aspx" + "';", true);

        }
    }
}