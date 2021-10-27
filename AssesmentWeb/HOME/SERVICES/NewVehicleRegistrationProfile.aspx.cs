using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssesmentWeb.HOME.SERVICES
{
    public partial class NewVehicleRegistrationProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

                PersonalInfo.DoFuunction();

                if (Convert.ToString(Session["Profile"]) == "Created")
                {
                    Response.Redirect("NewVehicleRegistrationFinal.aspx");
                }
            }
        }
    }
}