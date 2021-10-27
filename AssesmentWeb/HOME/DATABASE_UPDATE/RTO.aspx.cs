using BusinessLayer.DropDown;
using BusinessLayer.RTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ViewLayer.RTO;

namespace AssesmentWeb.HOME.DATABASE_UPDATE
{
    public partial class RTO : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CityViewList(ddlState);
            }
        }
        private void CityViewList(DropDownList ddl)
        {
            DropDownOperation dropDownOperation = new DropDownOperation();

            dropDownOperation.StateDropDowninDistrict(ddl);
        }

        protected void BtnRTO_Click(object sender, EventArgs e)
        {
            RTOViewModel rtoViewModel = new RTOViewModel();
            rtoViewModel.RTONo = Convert.ToString(txtRTOId.Text);
            rtoViewModel.RTOName = Convert.ToString(txtRTOName.Text);
            rtoViewModel.StateNo = Convert.ToString(ddlState.SelectedItem.Value);
            rtoViewModel.DistrictNo = Convert.ToString(ddlDistrict.SelectedItem.Value);
            rtoViewModel.CityNo = Convert.ToString(ddlCity.SelectedItem.Value);
            RTO_Operation rtoOperation = new RTO_Operation();
            rtoOperation.SaveRTODetails(rtoViewModel);
            lblRTOSuccess.Text = "Successfully Saved";
            MessageBox.Show("Successfully Saved");
            Response.Redirect("/HOME/dbUpdate");
        }

        protected void DropDownListState_SelectedIndexChanged(object sender, EventArgs e)
        {

            DropDownOperation dropDownOperation = new DropDownOperation();

            dropDownOperation.DistrictDropDowninDistrict(ddlDistrict, ddlState);

        }
        protected void DropDownListDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownOperation dropDownOperation = new DropDownOperation();

            dropDownOperation.CityDropDowninDistrict(ddlCity, ddlDistrict);


        }

       
    }
}