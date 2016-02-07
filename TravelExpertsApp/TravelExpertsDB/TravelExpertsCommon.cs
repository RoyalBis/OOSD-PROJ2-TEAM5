using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**********************************************************************
Title:                TravelExpertsCommon.cs  
 Project:          Travel Experts Desktop App
Authors:         Royal Bissell, Kevin Liao, Annie Ali, Lee Harrold
Class:               OOSD Fall 2015 
Date:               2016/02/07
Description:  Common Class for all methods that are used between the tables in the Travel 
                           Experts Database
**********************************************************************/

namespace TravelExpertsDB
{
    /// <summary>
    /// Static Class to Handle Methods Common to All Travel Experts DB Tables
    /// </summary>
    public static class TravelExpertsCommon
    {
        /// <summary>
        /// Get s aSql DB Connection to the TravelExperts Database
        /// </summary>
        /// <returns>SqlConnection</returns>
        public static SqlConnection GetConnection() //connection
        {
            string connectionString = "Data Source=localhost\\sait;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }

        /// <summary>
        /// Get a Command using the passed in string, and adds the connection object to the command
        /// </summary>
        /// <param name="sqlString">string, Query String</param>
        /// <returns></returns>
        internal static SqlCommand GetCommand(string sqlString)
        {
            //get the connection and make a new select statement
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            SqlCommand command = new SqlCommand(sqlString, connection);

            return command;
        }

        /// <summary>
        /// Performs Non Queries on the Database using the passed in command object. This Query must be designed to return only 1 result.
        /// </summary>
        /// <param name="command">SqlCommand</param>
        /// <returns></returns>
        internal static bool PerformNonQuery(SqlCommand command)
        {
            //Using will auto close the connection once the block is ended
            using (command.Connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    command.Connection.Open();

                    int nr = command.ExecuteNonQuery();   //nr is the number of rows that are affected
                    if (nr != 1)  //number of rows affected should be 1
                    {
                        //must have been more than one
                        return false;
                    }
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
            //It worked
            return true;
        }

        /// <summary>
        /// Performs Database Select Queries using the passed in command
        /// </summary>
        /// <param name="command">SqlCommand</param>
        /// <returns>SqlDataReader</returns>
        internal static SqlDataReader PerformQuery(SqlCommand command)
        //TODO: This should be integrated to all select queries
        {
            //Using will auto close the connection once the block is ended
            using (command.Connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    command.Connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    //returns the entire reader object to keep this method universal.
                    return reader;
                }
                catch ( Exception ex ) //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }
    }
}
