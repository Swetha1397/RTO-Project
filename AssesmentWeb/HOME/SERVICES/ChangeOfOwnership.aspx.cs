using BusinessLayer.CheckAadhar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewLayer.CheckAadhar;

namespace AssesmentWeb.HOME.SERVICES
{
    public partial class ChangeOfOwnership : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCheck_Click(object sender, EventArgs e)
        {
            CheckAadharViewModel checkAadharViewModel = new CheckAadharViewModel();
            checkAadharViewModel.AadharNo = Convert.ToInt64(txtChkAadhar.Text);
            Session["AadharNo"]= Convert.ToInt64(txtChkAadhar.Text); 

            CheckAadharOperation checkAadharOperation = new CheckAadharOperation();
            int Verify=checkAadharOperation.RTOCheckAadhar(checkAadharViewModel);

            if(Verify==1)
            {
                Response.Redirect("ChangeOfOwnershipFinal.aspx");
            }
            else
            {
                Response.Redirect("ChangeOfOwnershipProfile.aspx");
            }


        }
    }
}