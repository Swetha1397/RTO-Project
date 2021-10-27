using DataModel_Layer.ProfileInformation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ProfileInformation
{
    public class ProfileInformationDataOperation
    {
        public void SaveProfile(ProfileInformationDataModel profileInformationDataModel)
        {
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("InsertProfileInformation", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter("@FName", SqlDbType.VarChar);
            parameter1.Value = profileInformationDataModel.FName;
            command.Parameters.Add(parameter1);
            SqlParameter parameter2 = new SqlParameter("@LName", SqlDbType.VarChar);
            parameter2.Value = profileInformationDataModel.LName;
            command.Parameters.Add(parameter2);
            SqlParameter parameter3 = new SqlParameter("@DOB", SqlDbType.Date);
            parameter3.Value = profileInformationDataModel.DOB;
            command.Parameters.Add(parameter3);
            SqlParameter parameter4 = new SqlParameter("@AadharNo", SqlDbType.BigInt);
            parameter4.Value = profileInformationDataModel.AadharNo;
            command.Parameters.Add(parameter4);
            SqlParameter parameter5 = new SqlParameter("@Address", SqlDbType.VarChar);
            parameter5.Value = profileInformationDataModel.Address;
            command.Parameters.Add(parameter5);
            SqlParameter parameter6 = new SqlParameter("@StateNo", SqlDbType.VarChar);
            parameter6.Value = profileInformationDataModel.StateNo;
            command.Parameters.Add(parameter6);
            SqlParameter parameter7 = new SqlParameter("@DistrictNo", SqlDbType.VarChar);
            parameter7.Value = profileInformationDataModel.DistrictNo;
            command.Parameters.Add(parameter7);
            SqlParameter parameter8 = new SqlParameter("@CityNo", SqlDbType.VarChar);
            parameter8.Value = profileInformationDataModel.DistrictNo;
            command.Parameters.Add(parameter8);
            SqlParameter parameter9 = new SqlParameter("@AreaNo", SqlDbType.VarChar);
            parameter9.Value = profileInformationDataModel.AreaNo;
            command.Parameters.Add(parameter9);


            command.ExecuteNonQuery();
            sqlConnection.Close();
           
        }

        public ProfileInformationDataModel GetAddressDetails(string RTO)
        {
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("GetRTOGeographicalDetails", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter("@RTONo", SqlDbType.VarChar);
            parameter1.Value =RTO;
            command.Parameters.Add(parameter1);

            ProfileInformationDataModel profileInformationDataModel = new ProfileInformationDataModel();



            SqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {

                profileInformationDataModel.State = Convert.ToString(rdr["State"]);
                profileInformationDataModel.City = Convert.ToString(rdr["City"]);
                profileInformationDataModel.District = Convert.ToString(rdr["District"]);
                profileInformationDataModel.StateNo = Convert.ToString(rdr["StateNo"]);
                profileInformationDataModel.CityNo = Convert.ToString(rdr["CityNo"]);
                profileInformationDataModel.DistrictNo = Convert.ToString(rdr["DistrictNo"]);
               


            }

            rdr.Close();
            command.ExecuteNonQuery();
            sqlConnection.Close();
            return profileInformationDataModel;
        }

       
    }
}
