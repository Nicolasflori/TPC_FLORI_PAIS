using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace TPC_PAIS_FLORI
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void logout(object sender, EventArgs e)
        {
            Session.Abandon();
            Request.Cookies.Clear();
            Response.Redirect("Default.aspx");
        }
    }
}