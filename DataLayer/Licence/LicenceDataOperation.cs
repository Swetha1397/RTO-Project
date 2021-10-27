using DataModel_Layer.Licence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataLayer.Licence
{
    public class LicenceDataOperation
    {
        public int SaveLicenceDetails(LicenceDataModel licenceDataModel)
        {
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("GetLLRDetails", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter("@LLRNo", SqlDbType.VarChar);
            parameter1.Value = licenceDataModel.LLRNo;
            command.Parameters.Add(parameter1);
            string VehicleCategory = "";
            long AadharNo = 0;
            int Status = 0;
            DateTime? StartDate = null, ExpiryDate = null;
            SqlDataReader rdr = command.ExecuteReader();

            int verify = 0;
            while (rdr.Read())
            {



                AadharNo = Convert.ToInt64(rdr["AadharNo"]);
                VehicleCategory = rdr["VehicleCategory"].ToString();
                StartDate = Convert.ToDateTime(rdr["LLRStartDate"]).AddMonths(2);
                ExpiryDate = Convert.ToDateTime(rdr["LLREndDate"]);
                //verify = Convert.ToInt32(rdr["Verify"]);
            }

            rdr.Close();
            command.ExecuteNonQuery();



            //if (verify == 1)
            //{
            DateTime CurrentDate = DateTime.Today;



            if (ExpiryDate > CurrentDate)
            {
                if (CurrentDate > StartDate)
                {
                    //insertion procedure call
                    SqlCommand command1 = new SqlCommand("InsertLicense", sqlConnection);
                    command1.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameter2 = new SqlParameter("@LicenseNo", SqlDbType.VarChar);
                    parameter2.Value = licenceDataModel.LicenseNo;
                    command1.Parameters.Add(parameter2);
                    SqlParameter parameter3 = new SqlParameter("@VehicleCategory", SqlDbType.VarChar);
                    parameter3.Value = VehicleCategory;
                    command1.Parameters.Add(parameter3);
                    SqlParameter parameter4 = new SqlParameter("@AadharNo", SqlDbType.BigInt);
                    parameter4.Value = AadharNo;
                    command1.Parameters.Add(parameter4);
                    SqlDataReader rdr1 = command1.ExecuteReader();
                    while (rdr1.Read())
                    {
                        verify = Convert.ToInt32(rdr1["Verify"]);
                    }
                    rdr1.Close();
                    if (verify == 1)
                    {
                        command1.ExecuteNonQuery();
                        Status = 1;


                    }
                    else
                    {
                        // licenece already exist apply for upgradation
                        Status = -3;
                    }

                }
                else
                {
                    Status = -1;
                    //alert box of StartDt
                }
            }
            else
            {
                Status = -2;
                //alert box saying expired
            }

            //else
            //{
            // Status = -3;
            // // licenece already exist apply for upgradation
            //}




            sqlConnection.Close();
            return Status;



        }



        public string GenerateLicenceRegNo(String rtoNo)
        {
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("GetLastLicense", sqlConnection);
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
            ////////



            if (RegNo == "TNZero")
            {
                RegNoFinal = rtoNo + " " + DateTime.Now.Year.ToString() + " " + "0000001";
            }
            else
            {
                string r = null;
                string stcode = RegNo;
                int n = Convert.ToInt32(stcode.Substring(10, 7));



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
                RegNoFinal = rtoNo + " " + DateTime.Now.Year.ToString() + " " + r;



            }
            return RegNoFinal;



        }
    }
}