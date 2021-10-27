using BusinessLayer.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ViewLayer.State;

namespace AssesmentWeb.HOME.DATABASE_UPDATE
{
    public partial class State : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void BtnState_Click(object sender, EventArgs e)
        {
            StateViewModel stateDetails = new StateViewModel();
            stateDetails.StateNo = txtStateId.Text;
            stateDetails.StateName = txtStateName.Text;
            StateOperation stateOperation = new StateOperation();
            stateOperation.SaveStateDetails(stateDetails);
            lblStateSuccess.Text = "Added Succesfully";
            MessageBox.Show("Successfully Saved");
            Response.Redirect("/HOME/dbUpdate");
        }
    }
}