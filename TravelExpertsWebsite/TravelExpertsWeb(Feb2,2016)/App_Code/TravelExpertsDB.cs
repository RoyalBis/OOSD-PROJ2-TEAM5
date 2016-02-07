using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

// <Code Comment>
// Author: Anne Ali
// Date: Jan 28, 2016
// Class: OOSD Oct 2015
// Description: Database connection
// </Comment>

public class TravelExpertsDB
{
    public static SqlConnection GetConnection() //establish connection
    {
        string connectionString =
            "Data Source=localhost\\SAIT;Initial Catalog=TravelExperts;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        return connection;
    }
}