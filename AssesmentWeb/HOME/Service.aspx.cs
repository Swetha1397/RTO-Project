using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssesmentWeb.HOME
{
    public partial class Services : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNewVehicleRegistration_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HOME/SERVICES/NewVehicleRegistration.aspx");

        }

        protected void btnTransferOfOwnership_Click(object sender, EventArgs e)
        {

            Response.Redirect("/HOME/SERVICES/ChangeOfOwnership.aspx");
        }

        protected void btnLicenceRegistration_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HOME/SERVICES/LicenceRegistration.aspx");
        }
    }
}