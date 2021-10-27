using DataModel_Layer.City;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.City
{
    public class CityDataOperation
    {
        public void SaveCity(CityDataModel cityDataModel)
        {
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("InsertCityDetails", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@CityNo", SqlDbType.VarChar);
            param1.Value = cityDataModel.CityNo;
            command.Parameters.Add(param1);
            SqlParameter param2 = new SqlParameter("@CityName", SqlDbType.VarChar);
            param2.Value = cityDataModel.CityName;
            command.Parameters.Add(param2);
            SqlParameter param3 = new SqlParameter("@StateNo", SqlDbType.VarChar);
            param3.Value = cityDataModel.StateNo;
            command.Parameters.Add(param3);
            SqlParameter param4 = new SqlParameter("@DistrictNo", SqlDbType.VarChar);
            param4.Value = cityDataModel.DistrictNo;
            command.Parameters.Add(param4);
            command.ExecuteNonQuery();
            sqlConnection.Close();

        }
    }
}
