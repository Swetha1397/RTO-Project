using BusinessLayer.Area;
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
using ViewLayer.Area;

namespace AssesmentWeb.HOME.DATABASE_UPDATE
{
    public partial class Area : System.Web.UI.Page
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

        protected void BtnArea_Click(object sender, EventArgs e)
        {
            AreaViewModel areaViewModel = new AreaViewModel();
            areaViewModel.AreaNo = Convert.ToString(txtAreaId.Text);
            areaViewModel.AreaName = Convert.ToString(txtAreaName.Text);
            areaViewModel.RTONo = Convert.ToString(ddlRTO.SelectedItem.Value);
            areaViewModel.CityNo = Convert.ToString(ddlCity.SelectedItem.Value);
            areaViewModel.StateNo = Convert.ToString(ddlState.SelectedItem.Value);
            areaViewModel.DistrictNo = Convert.ToString(ddlDistrict.SelectedItem.Value);
            AreaOperation areaOperation = new AreaOperation();
            areaOperation.SaveAreaDetails(areaViewModel);
            lblAreaSuccess.Text = "Successfully Saved";
            MessageBox.Show("Successfully Saved");
            Response.Redirect("/HOME/dbUpdate");
        }

        protected void DropDownListCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownOperation dropDownOperation = new DropDownOperation();

            dropDownOperation.RTODropDowninDistrict(ddlRTO, ddlCity);
        }

        protected void DropDownListDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownOperation dropDownOperation = new DropDownOperation();

            dropDownOperation.CityDropDowninDistrict(ddlCity, ddlDistrict);


        }

        protected void DropDownListState_SelectedIndexChanged(object sender, EventArgs e)
        {

            DropDownOperation dropDownOperation = new DropDownOperation();

            dropDownOperation.DistrictDropDowninDistrict(ddlDistrict, ddlState);

        }
    }
}