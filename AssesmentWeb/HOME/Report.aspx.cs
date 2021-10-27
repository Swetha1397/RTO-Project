using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssesmentWeb.HOME
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnNewVehicleRegistrationReports1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HOME/REPORTS/NewVehicleRegistrationReport.aspx");
        }

        protected void BtnHistoryOfVehicleReports1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HOME/REPORTS/VehicleHistoryReport.aspx");
        }

        protected void BtnLLRReport1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HOME/REPORTS/LLRReport.aspx");

        }

        protected void BtnLicenceReport1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/HOME/REPORTS/LicenseReport.aspx");
        }
    }
}