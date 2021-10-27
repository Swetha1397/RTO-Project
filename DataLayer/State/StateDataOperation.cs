using DataModel_Layer.State;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.State
{
    public class StateDataOperation
    {
        public void SaveState(StateDataModel stateDataModel)
        {
            string connString = @"server=localhost;database=RTO;Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("InsertStateDetails", sqlConnection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter parameter1 = new SqlParameter("@StateNo", SqlDbType.VarChar);
            parameter1.Value = stateDataModel.StateNo;
            command.Parameters.Add(parameter1);
            SqlParameter parameter2 = new SqlParameter("@StateName", SqlDbType.VarChar);
            parameter2.Value = stateDataModel.StateName;
            command.Parameters.Add(parameter2);
            command.ExecuteNonQuery();
            sqlConnection.Close();

        }
    }
}
