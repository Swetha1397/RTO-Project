using BusinessLayer.CheckAadhar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewLayer.CheckAadhar;

namespace AssesmentWeb.HOME.DATABASE_UPDATE
{
    public partial class CheckAadhar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheckAadhar_Click(object sender, EventArgs e)
        {

            GetAadharAndVerifyDetails();
            

            //if (verify == 1)
            //{
            //    Session["AadharNo"]= long.Parse(txtAadhar.Text);
            //    Response.Redirect("NewVehicleRegistrationFinal.aspx");
            //}

            //else
            //{
            //    Response.Redirect("PersonalInfoRegistration.aspx");
            //}

        }

        public void GetAadharAndVerifyDetails()
        {
            CheckAadharViewModel checkAadharViewModel = new CheckAadharViewModel();
            checkAadharViewModel.AadharNo = long.Parse(txtAadhar.Text);
            CheckAadharOperation checkAadharOperation = new CheckAadharOperation();
            int verify = checkAadharOperation.RTOCheckAadhar(checkAadharViewModel);

            Session["Verify"] = verify;
            Session["AadharNo"] = txtAadhar.Text;
        }
    }
}