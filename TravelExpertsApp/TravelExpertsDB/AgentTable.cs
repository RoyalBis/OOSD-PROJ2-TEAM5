using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;

namespace TravelExpertsDB
{
    public static class AgentTable
    {

        //
        //Statement for SearchProducts()
        private const string SearchAll = "select AgentId, AgtFirstName, AgtMiddleInitial, AgtLastName, AgtEmail, AgtPosition from agents WHERE AgentId LIKE  '%' + @searchIndex + '%' OR AgtFirstName LIKE '%' + @searchIndex + '%' OR AgtMiddleInitial LIKE '%' + @searchIndex + '%' OR AgtLastName LIKE '%' + @searchIndex + '%'  OR AgtEmail LIKE '%' + @searchIndex + '%' OR AgtPosition LIKE '%' + @searchIndex + '%' ";

        public static bool Login(string AgentFirstName, string AgentPassword)
            {
                      
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            SqlCommand command = new SqlCommand("select AgtFirstName, AgentPassword from Agents where AgtFirstName=@username and AgentPassword=@password", connection);
            command.Parameters.AddWithValue("@username", AgentFirstName);
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
        public static List<Agent> SearchAllAgents(string searchIndex)
        {
            //We need a suppliers list to return; either a list of suppliers or an empty list
            List<Agent> agents = new List<Agent>();
            //get the connection and make a new select statement
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            SqlCommand selectCommand = new SqlCommand(SearchAll, connection);
            selectCommand.Parameters.AddWithValue("@searchIndex", searchIndex);

            //Using will auto close the connection once the block is ended
            using (connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    connection.Open();

                    SqlDataReader reader = selectCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        //build a new Product Object for each returned product
                        Agent agent = new Agent
                        {
                            AgentId = reader["AgentId"].ToString(),
                            AgentFirstName = reader["AgtFirstName"].ToString(),
                            AgentMiddleInitial = reader["AgtMiddleInitial"].ToString(),
                            AgentLastName = reader["AgtLastName"].ToString(),
                            AgentEmail = reader["AgtEmail"].ToString(),
                            AgentPosition = reader["AgtPosition"].ToString(),
                           
                        };
                        //add the agents to the list
                        agents.Add(agent);
                    }
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    agents = null;   //an error occurred so lets not continue
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }   //end of the using statement
            return agents;
        }
    }
}
