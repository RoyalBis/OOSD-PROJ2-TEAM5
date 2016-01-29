using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsDB
{
    public static class TravelExpertsCommon
    {
        public static SqlConnection GetConnection() //connection
        {
            string connectionString = "Data Source=localhost\\sait;Initial Catalog=TravelExperts;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }

        internal static SqlCommand GetCommand(string sqlString)
        {
            //get the connection and make a new select statement
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            SqlCommand command = new SqlCommand(sqlString, connection);

            return command;
        }

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
                        return false;
                    }
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
            return true;
        }

        internal static SqlDataReader PerformQuery(SqlCommand command)
        {
            //Using will auto close the connection once the block is ended
            using (command.Connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    command.Connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    return reader;
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    throw ex;
                }
                finally
                {
                    command.Connection.Close();
                }
            }   //end of the using statement
        }
    }
}
