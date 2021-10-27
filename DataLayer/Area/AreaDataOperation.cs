using DataModel_Layer.Area;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Area
{
    public class AreaDataOperation
    {
        public void SaveArea(AreaDataModel areaDataModel)
        {
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("InsertAreaDetails", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@AreaNo", SqlDbType.VarChar);
            param1.Value = areaDataModel.AreaNo;
            command.Parameters.Add(param1);
            SqlParameter param2 = new SqlParameter("@AreaName", SqlDbType.VarChar);
            param2.Value = areaDataModel.AreaName;
            command.Parameters.Add(param2);
            SqlParameter param3 = new SqlParameter("@RTONo", SqlDbType.VarChar);
            param3.Value = areaDataModel.RTONo;
            command.Parameters.Add(param3);
            SqlParameter param4 = new SqlParameter("@CityNo", SqlDbType.VarChar);
            param4.Value = areaDataModel.CityNo;
            command.Parameters.Add(param4);
            SqlParameter param5 = new SqlParameter("@StateNo", SqlDbType.VarChar);
            param5.Value = areaDataModel.StateNo;
            command.Parameters.Add(param5);
            SqlParameter param6 = new SqlParameter("@DistrictNo", SqlDbType.VarChar);
            param6.Value = areaDataModel.DistrictNo;
            command.Parameters.Add(param6);
            command.ExecuteNonQuery();
            sqlConnection.Close();

        }
    }
}
