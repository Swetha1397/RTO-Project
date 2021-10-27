using BusinessLayer.CheckRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ViewLayer.CheckRegistration;

namespace AssesmentWeb.HOME.SERVICES
{
    public partial class ChangeOfOwnershipFinal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCheck_Click(object sender, EventArgs e)
        {
            CheckRegistrationViewModel checkRegistrationViewModel = new CheckRegistrationViewModel();
            checkRegistrationViewModel.RegistrationNo = txtChkREGNO.Text;
            Session["RegNo"] = txtChkREGNO.Text;
            CheckRegistrationOperation checkRegistrationOperation = new CheckRegistrationOperation();
            int Verify=checkRegistrationOperation.CheckRegistrationRTO(checkRegistrationViewModel);
            if (Verify == 1)
            {
                checkRegistrationOperation.UpdateHistory(Convert.ToString(Session["RegNo"]), Convert.ToInt64(Session["AadharNo"]));
                MessageBox.Show("YOUR VEHICLE RE- REGISTERED");
                Response.Redirect("/HOME/Service");
            }
            else
            {
                MessageBox.Show("VEHICLE DOES NOT EXIST");
                Response.Redirect("/HOME/Service");

            }

        }
    }
}