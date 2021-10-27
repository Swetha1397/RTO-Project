using DataModel_Layer.CheckAadhar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.CheckAadhar
{
    public class CheckAadharDataOperation
    {
        public int CheckAadharRTO(CheckAadharDataModel checkAadharDataModel)
        {
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("CheckAadhar", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter("@AadharNo", SqlDbType.BigInt);
            parameter1.Value = checkAadharDataModel.AadharNo;
            command.Parameters.Add(parameter1);
            int Verify = 0;
            SqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {

                Verify = Convert.ToInt32(rdr["Verification"]);

            }
            rdr.Close();
            command.ExecuteNonQuery();
            sqlConnection.Close();
            return Verify;

        }
    }
}
