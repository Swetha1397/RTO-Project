using DataModel_Layer.CheckRegistration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.CheckRegistration
{
    public class CheckRegistrationDataOperation
    {
        public int RTOCheckRegistration(CheckRegistrationDataModel checkRegistrationDataModel)
        {
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("CheckRegistration", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter("@RegistrationNo", SqlDbType.VarChar);
            parameter1.Value = checkRegistrationDataModel.RegistrationNo;
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

        public void UpdateHistory(string RegNo, long Aadhar)
        {

            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("InsertHistory", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter("@RegNo", SqlDbType.VarChar);
            parameter1.Value = RegNo;
            command.Parameters.Add(parameter1);
            SqlParameter parameter2 = new SqlParameter("@AadharNo", SqlDbType.BigInt);
            parameter2.Value = Aadhar;
            command.Parameters.Add(parameter2);
            command.ExecuteNonQuery();
            sqlConnection.Close();

        }
    }
}
