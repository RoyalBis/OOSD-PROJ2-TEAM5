using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

// <Code Comment>
// Author: Anne Ali
// Date: Jan 28, 2016
// Class: OOSD Oct 2015
// Description: Data Access class for Package, method includes getpackage
// </Comment>

public static class PackageDB
{
    public static List<Package> GetPackage(int PackageId)
    {
        List<Package> packages = new List<Package>();
        SqlConnection connection = TravelExpertsDB.GetConnection();
        string selectStatement = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgImage " +
                                  "FROM Packages " +
                                  "Where PackageId = @PackageId";

        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
        selectCommand.Parameters.AddWithValue("@PackageId", PackageId);


        try
        {
            connection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();
            while (reader.Read())
            {
                Package pack = new Package();
                pack.PackageId = (int)reader["PackageId"];
                pack.PkgName = reader["PkgName"].ToString();
                pack.PkgDesc = reader["PkgDesc"].ToString();
                pack.PkgBasePrice = (decimal)reader["PkgBasePrice"];
                pack.PkgStartDate = (DateTime)reader["PkgStartDate"];
                pack.PkgEndDate = (DateTime)reader["PkgEndDate"];
                pack.PkgImage = (byte[]) reader["PkgImage"];

                packages.Add(pack);

            }
            reader.Close();
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        finally
        {
            connection.Close();
        }
        return packages;
    }
}