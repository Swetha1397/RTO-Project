using BusinessLayer.CheckAadhar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewLayer.CheckAadhar;

namespace AssesmentWeb.HOME.USER_CONTROLS
{
    public partial class LLRRegistration : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheckAadhar_Click(object sender, EventArgs e)
        {
            CheckAadharViewModel checkAadharViewModel = new CheckAadharViewModel();
            checkAadharViewModel.AadharNo = long.Parse(txtAadhar.Text);
            CheckAadharOperation checkAadharOperation = new CheckAadharOperation();
            int verify = checkAadharOperation.RTOCheckAadhar(checkAadharViewModel);
            if (verify == 1)
            {
                Session["LLRAadharNo"]= Convert.ToInt32(txtAadhar.Text);
                Response.Redirect("LLRRegistrationFinal.aspx");
            }

            else
            {
                Response.Redirect("PersonalInfoRegistration.aspx");
            }
        }
    }
}