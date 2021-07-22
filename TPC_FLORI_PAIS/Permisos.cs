using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_FLORI_PAIS
{
    public partial class Permisos : System.Web.UI.Page
    {
        public bool validarPermiso()
        {
            if (Session["usuario"] != null && ((Dominio.Usuarios)Session["usuario"]).IDPermiso != 1)
            {
                var page = HttpContext.Current.CurrentHandler as Page;
                ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "No tienes permisos para ingresar a esta pantalla" + "');window.location ='" + "../../Default.aspx" + "';", true);
                return false;
            }
            return true;
        }
    }
}