using BusinessLayer.District;
using BusinessLayer.DropDown;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ViewLayer.District;

namespace AssesmentWeb.HOME.DATABASE_UPDATE
{
    public partial class District : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                StateViewList(ddlState);
            }
        }
        private void StateViewList(DropDownList dropDown)
        {
            // DropDownList dropDown = new DropDownList();
            DropDownOperation dropDownOperation = new DropDownOperation();

            dropDownOperation.StateDropDowninDistrict(dropDown);
            //return dropDown;
        }



        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
          // StateViewList(ddlState);
        }

        protected void BtnDistrict_Click(object sender, EventArgs e)
        {
            DistrictViewModel districtViewModel = new DistrictViewModel();
            districtViewModel.DistrictNo = Convert.ToString(txtDistrictId.Text);
            districtViewModel.DistrictName = Convert.ToString(txtDistrictName.Text);
            districtViewModel.StateNo = Convert.ToString(ddlState.SelectedItem.Value);
            DistrictOperation districtOperation = new DistrictOperation();
            districtOperation.SaveDistrictDetails(districtViewModel);
            lblDistrictSuccess.Text = "Successfully Saved";
            MessageBox.Show("Successfully Saved");
            Response.Redirect("/HOME/dbUpdate");
        }
    }
}