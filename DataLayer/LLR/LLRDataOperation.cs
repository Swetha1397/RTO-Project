using DataModel_Layer.LLR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.LLR
{
    public class LLRDataOperation
    {
        public void SaveLLRDetails(LLRDataModel lLRDataModel)
        {
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("InsertLLR", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter("@LLRNo", SqlDbType.VarChar);
            parameter1.Value = lLRDataModel.LLRNo;
            command.Parameters.Add(parameter1);
            SqlParameter parameter2 = new SqlParameter("@AadharNo", SqlDbType.BigInt);
            parameter2.Value = lLRDataModel.AadharNo;
            command.Parameters.Add(parameter2);
            SqlParameter parameter3 = new SqlParameter("@VehicleCategory", SqlDbType.VarChar);
            parameter3.Value = lLRDataModel.VehicleCategory;
            command.Parameters.Add(parameter3);
            command.ExecuteNonQuery();
            sqlConnection.Close();

        }

        public string GenerateRegNo(String rtoNo)
        {

            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("GetLastLLRRegNo", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter("@rtoNo", SqlDbType.VarChar);
            parameter1.Value = rtoNo;
            command.Parameters.Add(parameter1);

            string RegNoFinal = "TN";

            string RegNo = "TN";

            SqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {

                RegNo = Convert.ToString(rdr["RegNo"]);

            }

            rdr.Close();
            command.ExecuteNonQuery();
            sqlConnection.Close();

            ////////////////////////////////////////////////////////////////////////
            if (RegNo == "TNZero")
            {
                RegNoFinal = rtoNo + "/" + "0000001" +"/"+ DateTime.Now.Year.ToString();
            }
            else
            {
                string r = null;
                string stcode = RegNo;
                int n = Convert.ToInt32(stcode.Substring(5, 7));

                if (n == 0000001 || n < 0000009)
                {
                    n = n + 1;
                    r = Convert.ToString(n);
                    r = "000000" + n;

                }
                else if (n == 0000009 || n < 0000100)
                {
                    n = n + 1;
                    r = Convert.ToString(n);
                    r = "00000" + n;


                }
                else if (n == 0000100 || n < 0001000)
                {
                    n = n + 1;
                    r = Convert.ToString(n);
                    r = "0000" + n;

                }
                else if (n == 0001000 || n < 0010000)
                {
                    n = n + 1;
                    r = Convert.ToString(n);
                    r = "000" + n;

                }
                else if (n == 0010000 || n < 0100000)
                {
                    n = n + 1;
                    r = Convert.ToString(n);
                    r = "00" + n;

                }
                else if (n == 010000 || n < 100000)
                {
                    n = n + 1;
                    r = Convert.ToString(n);
                    r = "0" + n;

                }
                else
                {

                    n = n + 1;
                    r = Convert.ToString(n);

                }
                RegNoFinal = rtoNo + "/" + r + "/" + DateTime.Now.Year.ToString();

            }
            return RegNoFinal;
        }
    }
}