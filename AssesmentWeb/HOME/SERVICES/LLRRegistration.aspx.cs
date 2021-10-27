using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AssesmentWeb.HOME.SERVICES
{
    public partial class LLRRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                CheckAadhar.GetAadharAndVerifyDetails();



                if (Convert.ToInt32(Session["verify"]) == 1)
                {
                    // Session["LLRAadharNo"] = Convert.ToInt32(txtAadhar.Text);



                    Response.Redirect("LLRRegistrationFinal.aspx");
                }



                else
                {
                    Response.Redirect("LLRregistragtionProfile.aspx");
                }
            }


        }
    }
}