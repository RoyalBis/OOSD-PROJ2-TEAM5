using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PackageDB
/// </summary>
public static class PackageDB
{
    public static List<Package> GetPackage(int PackageId)
    {
        List<Package> packages = new List<Package>();
        SqlConnection connection = TravelExpertsDB.GetConnection();
        string selectStatement = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission, PkgImage " +
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
                pack.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];
                pack.PkgStartDate = (DateTime)reader["PkgStartDate"];
                pack.PkgEndDate = (DateTime)reader["PkgEndDate"];

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