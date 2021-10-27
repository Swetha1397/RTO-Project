using DataModel_Layer.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Login
{
    public class LoginDataOperation
    {
        public int LoginRTO(LoginDataModel loginDataModel)
        {
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Validate_User", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter("@Username", SqlDbType.VarChar);
            parameter1.Value = loginDataModel.RTO_No;
            command.Parameters.Add(parameter1);
            SqlParameter parameter2 = new SqlParameter("@Password", SqlDbType.VarChar);
            parameter2.Value = loginDataModel.Password;
            command.Parameters.Add(parameter2);
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
