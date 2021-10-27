using BusinessLayer.DropDown;
using BusinessLayer.ProfileInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ViewLayer.ProfileInformation;

namespace AssesmentWeb.HOME.DATABASE_UPDATE
{
    public partial class PersonalInfo : System.Web.UI.UserControl
    {
        //string StateNo, DistrictNo, CityNo, AreaNo;
        ProfileInformationViewModel ProfileInformationView = new ProfileInformationViewModel();

        protected void Page_Load(object sender, EventArgs e)
        {

            DoStartUp();
            
        }

        protected void ddlArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            DoFuunction();
            
        
        }
        public void DoFuunction()
        {
            DoStartUp();
            string RTO = Convert.ToString(Session["RTONO"]);
            ProfileInformationViewModel profileInformationViewModel = new ProfileInformationViewModel();
            ProfileInformationOperation profileInformationOperation = new ProfileInformationOperation();
            profileInformationViewModel = profileInformationOperation.GetAddressDetails(RTO);

            profileInformationViewModel.FName = txtFirstName.Text;
            profileInformationViewModel.LName = txtLastName.Text;
            profileInformationViewModel.DOB = Convert.ToDateTime(txtDob.Text);
            profileInformationViewModel.AadharNo = Convert.ToInt64(Session["AadharNo"]);
            profileInformationViewModel.Address = TextAreaAddress.Value;
            //profileInformationViewModel.StateNo = ProfileInformationView.StateNo;
            //profileInformationViewModel.DistrictNo = ProfileInformationView.DistrictNo;
            //profileInformationViewModel.CityNo = ProfileInformationView.CityNo;

            profileInformationViewModel.AreaNo = ddlArea.Text;

            profileInformationOperation.RTOProfileInformation(profileInformationViewModel);
            lblRegSuccess.Text = "Registered SuccessFull";
            Session["Profile"] = "Created";
        }
        public void DoStartUp()
        {
            lblAadharNo.Text = Convert.ToString(Session["AadharNo"]);

            string RTO = Convert.ToString(Session["RTONO"]);

            ProfileInformationViewModel profileInformationViewModel = new ProfileInformationViewModel();
            ProfileInformationOperation profileInformationOperation = new ProfileInformationOperation();
            profileInformationViewModel = profileInformationOperation.GetAddressDetails(RTO);

            lblStateDisp.Text = profileInformationViewModel.State;
            lblDistrictDisp.Text = profileInformationViewModel.District;
            lblCityDisp.Text = profileInformationViewModel.City;
            //ProfileInformationView.StateNo = profileInformationViewModel.StateNo;
            //ProfileInformationView.DistrictNo = profileInformationViewModel.DistrictNo;
            //ProfileInformationView.CityNo = profileInformationViewModel.CityNo;
            //ProfileInformationView.AreaNo = profileInformationViewModel.AreaNo;


            DropDownOperation dropDownOperation = new DropDownOperation();

            dropDownOperation.AreaDropDown(ddlArea, RTO);

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}