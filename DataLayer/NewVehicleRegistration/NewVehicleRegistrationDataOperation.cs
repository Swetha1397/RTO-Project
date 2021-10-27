using DataModel_Layer.NewVehicleRegistration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.NewVehicleRegistration
{
    public class NewVehicleRegistrationDataOperation
    {
        public void SaveVehicleRegistration(NewVehicleRegistrationDataModel newVehicleRegistrationDataModel)
        {
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("InsertVehicle_Registration", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter("@AadharNo", SqlDbType.BigInt);
            parameter1.Value = newVehicleRegistrationDataModel.AadharNo;
            command.Parameters.Add(parameter1);
            SqlParameter parameter2 = new SqlParameter("@RegistrationNo", SqlDbType.VarChar);
            parameter2.Value = newVehicleRegistrationDataModel.RegNo;
            command.Parameters.Add(parameter2);
            SqlParameter parameter3 = new SqlParameter("@VehicleName", SqlDbType.VarChar);
            parameter3.Value = newVehicleRegistrationDataModel.VehicleName;
            command.Parameters.Add(parameter3);
            SqlParameter parameter4 = new SqlParameter("@EngineNo", SqlDbType.VarChar);
            parameter4.Value = newVehicleRegistrationDataModel.EngineNo;
            command.Parameters.Add(parameter4);
            SqlParameter parameter5 = new SqlParameter("@ChasisNo", SqlDbType.VarChar);
            parameter5.Value = newVehicleRegistrationDataModel.ChasisNo;
            command.Parameters.Add(parameter5);
            command.ExecuteNonQuery();
            sqlConnection.Close();


        }

        public string GenerateRegNo(String rtoNo)
        {
            
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("GetLastRegNo", sqlConnection);
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
                RegNoFinal = rtoNo + " " + "AA" + " " + "0001";
            }
            else
            {
                string a1, a2;
                string r = null;

                string stcode = RegNo;
                // string stcode = "TN12 BZ 9999"; //db value
                int n = Convert.ToInt16(stcode.Substring(8));// last four digit
                a1 = stcode.Substring(5, 1);//1st alphabet
                a2 = stcode.Substring(6, 1);//2nd alphabet
                char b1 = Convert.ToChar(a1);
                char b2 = Convert.ToChar(a2);
                if (n == 9999)
                {
                    r = "0001";
                    if (b2 == 'Z')
                    {
                        b2 = 'A';
                        b1 = (char)(((int)b1) + 1);
                    }
                    else
                    {
                        b2 = (char)(((int)b2) + 1);
                    }


                }
                else
                {

                    if (n == 0001 || n < 0009)
                    {
                        n = n + 1;
                        r = Convert.ToString(n);
                        r = "000" + n;

                    }
                    else if (n == 0009 || n < 0100)
                    {
                        n = n + 1;
                        r = Convert.ToString(n);
                        r = "00" + n;
                        //num = Convert.ToInt16(r) + 1;

                    }
                    else if (n == 0100 || n < 1000)
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

                }

                RegNoFinal = rtoNo + " " + b1 + b2 + " " + r;
            }
            


            return RegNoFinal; 

        }
    }
}
