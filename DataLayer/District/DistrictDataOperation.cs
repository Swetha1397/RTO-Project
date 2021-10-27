using DataModel_Layer.District;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace DataLayer.District
{
    public class DistrictDataOperation
    {
        public void SaveDistrict(DistrictDataModel districtDataModel)
        {
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("InsertDistrictDetails", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@DistrictNo", SqlDbType.VarChar);
            param1.Value = districtDataModel.DistrictNo;
            command.Parameters.Add(param1);
            SqlParameter param2 = new SqlParameter("@DistrictName", SqlDbType.VarChar);
            param2.Value = districtDataModel.DistrictName;
            command.Parameters.Add(param2);
            SqlParameter param3 = new SqlParameter("@StateNo", SqlDbType.VarChar);
            param3.Value = districtDataModel.StateNo;
            command.Parameters.Add(param3);
            command.ExecuteNonQuery();
            sqlConnection.Close();


        }

        
    }
}
