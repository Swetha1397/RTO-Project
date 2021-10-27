using BusinessLayer.CheckRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewLayer.CheckRegistration;

namespace AssesmentWeb.HOME.USER_CONTROLS
{
    public partial class CheckRegistrationNo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheckRegistrationNo_Click(object sender, EventArgs e)
        {
            CheckRegistrationViewModel checkRegistrationViewModel = new CheckRegistrationViewModel();
            checkRegistrationViewModel.RegistrationNo = txtRegistrationNo.Text;
            CheckRegistrationOperation checkRegistrationOperation = new CheckRegistrationOperation();
            int verify = checkRegistrationOperation.CheckRegistrationRTO(checkRegistrationViewModel);
            if (verify == 1)
            {
                Response.Redirect("NewVehicleRegistrationFinal.aspx");
            }
            else
            {
                Response.Write("Registration Number not exist");
            }

        }
    }
}