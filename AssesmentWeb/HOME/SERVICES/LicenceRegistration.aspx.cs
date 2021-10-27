using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssesmentWeb.HOME.SERVICES
{
    public partial class LicenceRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLLRRegistration_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HOME/SERVICES/LLRRegistration.aspx");
        }

        protected void btnLicenceRegistration_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HOME/SERVICES/LicenceRegistrationFinal.aspx");
        }
    }
}