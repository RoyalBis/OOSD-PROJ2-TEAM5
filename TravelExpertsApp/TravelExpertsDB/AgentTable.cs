using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;

/**********************************************************************
Title:                AgentTable.cs  
 Project:          Travel Experts Desktop App
Authors:         Royal Bissell, Kevin Liao, Annie Ali, Lee Harrold
Class:               OOSD Fall 2015 
Date:               2016/02/07
Description:  Data Access Class for Quering the Agent Table in the Travel Experts Database
**********************************************************************/

namespace TravelExpertsDB
{
    /// <summary>
    /// TravelExperts Agents Table Access Class
    /// </summary>
    public static class AgentTable
    {

        #region Query Strings
        //Statement for Search All Agents, Unused...
        private const string SearchAll = "SELECT AgentId, AgtFirstName, AgtMiddleInitial, AgtLastName, AgtEmail, AgtPosition " +
                                         "FROM agents WHERE AgentId LIKE  '%' + @searchIndex + '%' OR AgtFirstName " +
                                         "LIKE '%' + @searchIndex + '%' " +
                                         "OR AgtMiddleInitial LIKE '%' + @searchIndex + '%' " +
                                         "OR AgtLastName LIKE '%' + @searchIndex + '%'  " +
                                         "OR AgtEmail LIKE '%' + @searchIndex + '%' " +
                                         "OR AgtPosition LIKE '%' + @searchIndex + '%' ";

        //Statement to login an Agent
        private const string LoginStmt ="SELECT AgtFirstName, AgentPassword " +
                                                                           "FROM Agents " +
                                                                           "WHERE AgtFirstName = @username " +
                                                                           "AND AgentPassword = @password";
        #endregion

        #region Queries
        /// <summary>
        /// Query to login the agent
        /// </summary>
        /// <param name="AgentFirstName">string</param>
        /// <param name="AgentPassword">string</param>
        /// <returns>true if the username and password match one in the database.</returns>
        public static bool Login(string AgentFirstName, string AgentPassword)
        {
            //Call the common function to retrieve an sql command
            SqlCommand command = TravelExpertsCommon.GetCommand(LoginStmt);
            //Add the parameters
            command.Parameters.AddWithValue("@username", AgentFirstName);
            command.Parameters.AddWithValue("@password", AgentPassword);

            //Using will auto close the connection once the block is ended
            using (command.Connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    //open the connection
                    command.Connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    if ( reader.Read() )
                    {
                        //just return true if the agent was able to login, we don't care who the agent is later on
                        return true;
                    }
                    return false;
                }
                catch ( Exception ex ) //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// Searches for an agent based on any of their fields.
        /// </summary>
        /// <param name="searchIndex">string</param>
        /// <returns>List of  matched Agents</returns>
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
                    throw ex;
                }
            }   //end of the using statement
            return agents;
        }
#endregion
    }
}
