using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace TravelExpertsDB
{
    public static class PackagesTable
    {
        public static PackageList GetAllPackages()
        {
            PackageList packages = new PackageList();    

            SqlConnection connection = TravelExpertsCommon.GetConnection();

            string selectString =
                "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission, PkgImage " +
                "FROM Packages";
            SqlCommand selectCommand = new SqlCommand(selectString, connection);
 
            //Using will auto close the connection once the block is ended
            using (connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    connection.Open();

                    SqlDataReader reader = selectCommand.ExecuteReader();
                    while ( reader.Read() )
                    {
                        Package pack = new Package();
                        pack.PackageId = (int)reader["PackageId"];
                        pack.PkgName = reader["PkgName"].ToString();
                        pack.PkgDesc = reader["PkgDesc"].ToString();
                        pack.PkgBasePrice = (decimal)reader["PkgBasePrice"];
                        pack.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];
                        pack.PkgStartDate = (DateTime)reader["PkgStartDate"];
                        pack.PkgEndDate = (DateTime)reader["PkgEndDate"];
                        if (reader["PkgImage"] is DBNull)
                        {
                            pack.PkgImage = null;
                        }
                        else
                        {
                            pack.PkgImage = (byte[])reader["PkgImage"];
                        }
                        packages.Add(pack);
                    }
                }
                catch ( Exception ex ) //catch all exceptions and re-throw them
                {
                    packages = null; //an error occurred so lets not continue
                    throw ex;
                }
            }   //end of the using statement
            return packages;
        }
        //Statement for SearchAllProducts()
        private const string SearchAll = "select PackageId,PkgName, PkgStartDate, PkgEndDate,PkgDesc,PkgBasePrice,PkgAgencyCommission from packages WHERE PackageId LIKE  '%' + @searchIndex + '%' OR PkgName LIKE '%' + @searchIndex + '%' OR PkgStartDate LIKE '%' + @searchIndex + '%' OR PkgEndDate LIKE '%' + @searchIndex + '%' OR PkgDesc LIKE '%' + @searchIndex + '%'    OR PkgBasePrice LIKE '%' + @searchIndex + '%' OR PkgAgencyCommission LIKE '%' + @searchIndex + '%' ";
        public static Package SearchPackage(int packageId) //Search method
        {
            SqlConnection connection = TravelExpertsCommon.GetConnection();

            string selectString = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission, PkgImage " +
                                  "FROM Packages " +
                                  "WHERE PackageId = @PackageId";
            SqlCommand selectCommand = new SqlCommand(selectString, connection);
            selectCommand.Parameters.AddWithValue("@PackageId", packageId);
            try
            {
                connection.Open();
                SqlDataReader packageReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (packageReader.Read())
                {
                    Package pack = new Package();
                    pack.PackageId = (int)packageReader["PackageId"];
                    pack.PkgName = packageReader["PkgName"].ToString();
                    pack.PkgDesc = packageReader["PkgDesc"].ToString();
                    pack.PkgBasePrice = (decimal)packageReader["PkgBasePrice"];
                    pack.PkgAgencyCommission = (decimal)packageReader["PkgAgencyCommission"];
                    pack.PkgStartDate = (DateTime)packageReader["PkgStartDate"];
                    pack.PkgEndDate = (DateTime)packageReader["PkgEndDate"];
                    pack.PkgImage = (byte[])packageReader["PkgImage"];

                    packageReader.Close();
                    return pack;
                }
                else
                {
                    return null;
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

        public static int AddPackage(Package pack) //add product method
        {
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            string insertStatement = "INSERT INTO Packages " +
                                     "(PkgName, PkgDesc, PkgStartDate, PkgEndDate, PkgBasePrice, PkgAgencyCommission, PkgImage) " +
                                     "Values(@PkgName, @PkgDesc, @PkgStartDate, @PkgEndDate, @PkgBasePrice, @PkgAgencyCommission, @PkgImage)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@PkgName", pack.PkgName);
            insertCommand.Parameters.AddWithValue("@PkgDesc", pack.PkgDesc);
            insertCommand.Parameters.AddWithValue("@PkgStartDate", pack.PkgStartDate);
            insertCommand.Parameters.AddWithValue("@PkgEndDate", pack.PkgEndDate);
            insertCommand.Parameters.AddWithValue("@PkgBasePrice", pack.PkgBasePrice);
            insertCommand.Parameters.AddWithValue("@PkgAgencyCommission", pack.PkgAgencyCommission);
            insertCommand.Parameters.AddWithValue("@PkgImage", pack.PkgImage);
            try
            {
                connection.Open();
                int indicator = insertCommand.ExecuteNonQuery();
                if (indicator > 0)
                {
                    string selectStatement = "SELECT IDENT_CURRENT('Packages') " +
                           "FROM Packages";
                    SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
                    int packageId = int.Parse(selectCommand.ExecuteScalar().ToString()); //first col of the row is selected
                    return packageId;
                }
                else
                {
                    return -1;
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

        public static int UpdatePackage(Package oldPack, Package newPack) //update method
        {
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            string updateStatement = "UPDATE Packages " +
                                     "SET PkgName = @NewPkgName, " +
                                     "PkgDesc = @NewPkgDesc, " +
                                     "PkgStartDate = @NewPkgStartDate, " +
                                     "PkgEndDate = @NewPkgEndDate, " +
                                     "PkgBasePrice = @NewPkgBasePrice, " +
                                     "PkgAgencyCommission = @NewPkgAgencyCommission, " +
                                     "PkgImage = @NewPkgImage " +
                                     "WHERE PackageId = @PackageId " +
                                     "AND PkgName = @OldPkgName " +
                                     "AND PkgDesc = @OldPkgDesc " +
                                     "AND PkgStartDate = @OldPkgStartDate " +
                                     "AND PkgEndDate = @OldPkgEndDate " +
                                     "AND PkgBasePrice = @OldPkgBasePrice " +
                                     "AND PkgAgencyCommission = @OldPkgAgencyCommission " +
                                     "AND (PkgImage = @OldPkgImage "  +
                                     "OR @OldPkgImage IS NULL AND PkgImage IS NULL)";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@OldPkgName", oldPack.PkgName);
            updateCommand.Parameters.AddWithValue("@OldPkgDesc", oldPack.PkgDesc);
            updateCommand.Parameters.AddWithValue("@OldPkgStartDate", oldPack.PkgStartDate);
            updateCommand.Parameters.AddWithValue("@OldPkgEndDate", oldPack.PkgEndDate);
            updateCommand.Parameters.AddWithValue("@OldPkgBasePrice", oldPack.PkgBasePrice);
            updateCommand.Parameters.AddWithValue("@OldPkgAgencyCommission", oldPack.PkgAgencyCommission);
            if ( oldPack.PkgImage == null )
            {
                updateCommand.Parameters.AddWithValue("@OldPkgImage", DBNull.Value);
            }
            else
            {
                updateCommand.Parameters.AddWithValue("@OldPkgImage", oldPack.PkgImage);
            }
            updateCommand.Parameters.AddWithValue("@PackageId", oldPack.PackageId);
            updateCommand.Parameters.AddWithValue("@NewPkgName", newPack.PkgName);
            updateCommand.Parameters.AddWithValue("@NewPkgDesc", newPack.PkgDesc);
            updateCommand.Parameters.AddWithValue("@NewPkgStartDate", newPack.PkgStartDate);
            updateCommand.Parameters.AddWithValue("@NewPkgEndDate", newPack.PkgEndDate);
            updateCommand.Parameters.AddWithValue("@NewPkgBasePrice", newPack.PkgBasePrice);
            updateCommand.Parameters.AddWithValue("@NewPkgAgencyCommission", newPack.PkgAgencyCommission);
            updateCommand.Parameters.AddWithValue("@NewPkgImage", newPack.PkgImage);

            try
            {
                connection.Open();
                int indicator = updateCommand.ExecuteNonQuery();
                if (indicator > 0)
                {
                    return oldPack.PackageId;
                }
                else
                {
                    return -1;
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

        public static bool DeletePackage(Package pack) //delete method
        {
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            string deleteStatement = "DELETE Packages " +
                                     "WHERE PackageId = @PackageId " +
                                     "  AND PkgName = @PkgName " +
                                     "  AND PkgDesc = @PkgDesc " +
                                     "  AND PkgStartDate = @PkgStartDate " +
                                     "  AND PkgEndDate = @PkgEndDate " +
                                     "  AND PkgBasePrice = @PkgBasePrice " +
                                     "  AND PkgAgencyCommission = @PkgAgencyCommission " +
                                     "  AND PkgImage = @PkgImage";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@PackageId", pack.PackageId);
            deleteCommand.Parameters.AddWithValue("@PkgName", pack.PkgName);
            deleteCommand.Parameters.AddWithValue("@PkgDesc", pack.PkgDesc);
            deleteCommand.Parameters.AddWithValue("@PkgStartDate", pack.PkgStartDate);
            deleteCommand.Parameters.AddWithValue("@PkgEndDate", pack.PkgEndDate);
            deleteCommand.Parameters.AddWithValue("@PkgBasePrice", pack.PkgBasePrice);
            deleteCommand.Parameters.AddWithValue("@PkgAgencyCommission", pack.PkgAgencyCommission);
            deleteCommand.Parameters.AddWithValue("@PkgImage", pack.PkgImage);

            try
            {
                connection.Open();
                int indicator = deleteCommand.ExecuteNonQuery();
                if (indicator > 0)
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
        public static List<Package> SearchAllPackages(string searchIndex)
        {
            //We need a suppliers list to return; either a list of suppliers or an empty list
            List<Package> packages = new List<Package>();
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
                        Package package = new Package
                        {
                            PackageId = (int)reader["PackageId"],
                            PkgName = reader["PkgName"].ToString(),
                            PkgStartDate = (DateTime)reader["PkgStartDate"],
                            PkgEndDate = (DateTime)reader["PkgEndDate"],
                            PkgDesc = reader["PkgDesc"].ToString(),
                            PkgBasePrice = (decimal)reader["PkgBasePrice"],
                            PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"],
                        };
                        //add the packages to the list
                        packages.Add(package);
                    }
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    packages = null;   //an error occurred so lets not continue
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }   //end of the using statement
            return packages;
        }

    }
}
