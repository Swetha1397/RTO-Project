using DataModel_Layer.RTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.RTO
{
    public class RTODataOperation
    {
        public void SaveRTO(RTODataModel rtoDataModel)
        {
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("InsertRTODetails", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@RTONo", SqlDbType.VarChar);
            param1.Value = rtoDataModel.RTONo;
            command.Parameters.Add(param1);
            SqlParameter param2 = new SqlParameter("@RTOName", SqlDbType.VarChar);
            param2.Value = rtoDataModel.RTOName;
            command.Parameters.Add(param2);
            SqlParameter param3 = new SqlParameter("@StateNo", SqlDbType.VarChar);
            param3.Value = rtoDataModel.StateNo;
            command.Parameters.Add(param3);
            SqlParameter param4 = new SqlParameter("@DistrictNo", SqlDbType.VarChar);
            param4.Value = rtoDataModel.DistrictNo;
            command.Parameters.Add(param4);
            SqlParameter param5 = new SqlParameter("@CityNo", SqlDbType.VarChar);
            param5.Value = rtoDataModel.CityNo;
            command.Parameters.Add(param5);
            command.ExecuteNonQuery();
            sqlConnection.Close();


        }
    }
}
