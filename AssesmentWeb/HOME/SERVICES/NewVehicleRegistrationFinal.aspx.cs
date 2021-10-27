using BusinessLayer.NewVehicleRegistration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ViewLayer.NewVehicleRegistration;

namespace AssesmentWeb.HOME.SERVICES
{
    public partial class NewVehicleRegistrationFinal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            
            NewVehicleRegistrationViewModel newVehicleRegistrationViewModel = new NewVehicleRegistrationViewModel();
            newVehicleRegistrationViewModel.AadharNo = Convert.ToInt64(Session["AadharNo"].ToString());
            newVehicleRegistrationViewModel.ChasisNo = txtChasisNo.Text;
            newVehicleRegistrationViewModel.EngineNo = txtEngineNo.Text;
            newVehicleRegistrationViewModel.VehicleName = txtVehicleName.Text;
            string rtono = Session["RTONO"].ToString();
            NewVehicleRegistrationOperation newVehicleRegistrationOperation = new NewVehicleRegistrationOperation();
            newVehicleRegistrationViewModel.RegNo = newVehicleRegistrationOperation.GetRegNo(rtono);
            newVehicleRegistrationOperation.SaveVehicleRegistrationDetails(newVehicleRegistrationViewModel);
            
            MessageBox.Show("Vehicle Registration No:" + newVehicleRegistrationViewModel.RegNo);
            Response.Redirect("/HOME/Service");

        }
    }
}