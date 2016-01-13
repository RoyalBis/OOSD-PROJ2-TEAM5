using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public static class AgentTable
    {
        public static bool Login(string AgentName, string AgentPassword)
            {
                      
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            SqlCommand command = new SqlCommand("select AgtFirstName, AgentPassword from Agents where AgtFirstName=@username and AgentPassword=@password", connection);
            command.Parameters.AddWithValue("@username", AgentName);
            command.Parameters.AddWithValue("@password", AgentPassword);
            int count = -1;
            try
            {
               connection.Open();
               count = command.ExecuteNonQuery();

                if (count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
