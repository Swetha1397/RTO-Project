using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace DataLayer.DropDown
{
    public class DropDownDataOperation
    {
        public void GetStateDropdowns(DropDownList dropDown)
        {
            //DropDownList dropDown = new DropDownList();

            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("GetStateDetails", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dropDown.DataSource = dt;
            dropDown.DataValueField = "StateNo";
            dropDown.DataTextField = "StateName";
            dropDown.DataBind();

            // return dropDown;
        }

        public void GetDistrictDropdowns(DropDownList dropDownListDistrict, DropDownList dropDownListState)
        {
            dropDownListDistrict.Items.Clear();
            dropDownListDistrict.Items.Add("Select District");
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("GetDistrict", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter1 = new SqlParameter("@StateNo", SqlDbType.VarChar);
            parameter1.Value = Convert.ToString(dropDownListState.SelectedItem.Value);
            command.Parameters.Add(parameter1);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dropDownListDistrict.DataSource = dt;
            dropDownListDistrict.DataValueField = "DistrictNo";
            dropDownListDistrict.DataTextField = "DistrictName";
            dropDownListDistrict.DataBind();
        }

        public void GetCityDropdowns(DropDownList dropDownListCity, DropDownList dropDownListDistrict)
        {
            dropDownListCity.Items.Clear();
            dropDownListCity.Items.Add("Select City");
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("GetCity", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter1 = new SqlParameter("@DistrictNo", SqlDbType.VarChar);
            parameter1.Value = Convert.ToString(dropDownListDistrict.SelectedItem.Value);
            command.Parameters.Add(parameter1);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dropDownListCity.DataSource = dt;
            dropDownListCity.DataTextField = "CityName";
            dropDownListCity.DataValueField = "CityNo";
            dropDownListCity.DataBind();
        }

        public void GetRTODropdowns(DropDownList dropDownListRto, DropDownList dropDownListCity)
        {
            dropDownListRto.Items.Clear();
            dropDownListRto.Items.Add("Select RTO");
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("GetRTO", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter1 = new SqlParameter("@CityNo", SqlDbType.VarChar);
            parameter1.Value = Convert.ToString(dropDownListCity.SelectedItem.Value);
            command.Parameters.Add(parameter1);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dropDownListRto.DataSource = dt;
            dropDownListRto.DataTextField = "RTOName";
            dropDownListRto.DataValueField = "RTONo";
            dropDownListRto.DataBind();
        }

        public void GetAreaDropdowns(DropDownList dropDownListArea, string RTO)
        {
            dropDownListArea.Items.Clear();
            dropDownListArea.Items.Add("Select Area");
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("GetArea", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter1 = new SqlParameter("@RTONo", SqlDbType.VarChar);
            parameter1.Value = RTO;
            command.Parameters.Add(parameter1);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dropDownListArea.DataSource = dt;
            dropDownListArea.DataTextField = "AreaName";
            dropDownListArea.DataValueField = "AreaNo";
            dropDownListArea.DataBind();

        }


    }
}
