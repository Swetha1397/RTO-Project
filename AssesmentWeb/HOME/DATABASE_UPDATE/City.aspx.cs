using BusinessLayer.City;
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
using ViewLayer.City;

namespace AssesmentWeb.HOME.DATABASE_UPDATE
{
    public partial class City : System.Web.UI.Page
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

        

        protected void DropDownListState_SelectedIndexChanged(object sender, EventArgs e)
        {

            DropDownOperation dropDownOperation = new DropDownOperation();

            dropDownOperation.DistrictDropDowninDistrict(ddlDistrict, ddlState);

        }

        //protected void DropDownListDistrict_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ddlDistrict.Items.Clear();
        //    ddlDistrict.Items.Add("Select City");
        //    string connString = @"server=localhost;database=RTO;Integrated Security=True;";
        //    SqlConnection sqlConnection = new SqlConnection(connString);
        //    sqlConnection.Open();
        //    SqlCommand command = new SqlCommand("GetCity", sqlConnection);
        //    command.CommandType = CommandType.StoredProcedure;

        //    SqlParameter parameter1 = new SqlParameter("@DistrictNo", SqlDbType.VarChar);
        //    parameter1.Value = Convert.ToString(ddlDistrict.SelectedItem.Value);
        //    command.Parameters.Add(parameter1);

        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
        //    DataTable dt = new DataTable();
        //    sqlDataAdapter.Fill(dt);
        //    ddlDistrict.DataSource = dt;
        //    ddlDistrict.DataTextField = "CityName";
        //    ddlDistrict.DataValueField = "CityNo";
        //    ddlDistrict.DataBind();
        //}

        protected void BtnCity_Click(object sender, EventArgs e)
        {
            CityViewModel cityViewModel = new CityViewModel();
            cityViewModel.CityNo = Convert.ToString(txtCityId.Text);
            cityViewModel.CityName = Convert.ToString(txtCityName.Text);
            cityViewModel.StateNo = Convert.ToString(ddlState.SelectedItem.Value);
            cityViewModel.DistrictNo = Convert.ToString(ddlDistrict.SelectedItem.Value);

            CityOperation cityOperation = new CityOperation();
            cityOperation.SaveCityDetails(cityViewModel);
            lblCitySuccess.Text = "Successfully Saved";
            MessageBox.Show("Successfully Saved");
            Response.Redirect("/HOME/dbUpdate");
        }
    }
}