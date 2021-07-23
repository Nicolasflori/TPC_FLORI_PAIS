using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TPC_PAIS_FLORI
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar(object sender, EventArgs e)
        {
           NegocioEmail emailService = new NegocioEmail();
           emailService.armarCorreoContacto(txtEmail.Text, txtAsunto.Text, txtCuerpo.Text);
           try
           {
                emailService.enviarEmail();
                var page = HttpContext.Current.CurrentHandler as Page;
                ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "Email Enviado!" + "');window.location ='" + "Default.aspx" + "';", true);
            }
           catch (Exception ex)
           {
               throw ex;
           }

        }

        protected void btnReset(object sender, EventArgs e)
        {
            txtAsunto.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCuerpo.Text = string.Empty;
        }

    }
}