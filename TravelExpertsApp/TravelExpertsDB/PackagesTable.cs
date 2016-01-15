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
        public static Package SearchPackage(int packageId) //Search method
        {
            SqlConnection connection = TravelExpertsCommon.GetConnection();

            string selectString = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
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
                                     "(PkgName, PkgDesc, PkgStartDate, PkgEndDate, PkgBasePrice, PkgAgencyCommission) " +
                                     "Values(@PkgName, @PkgDesc, @PkgStartDate, @PkgEndDate, @PkgBasePrice, @PkgAgencyCommission)";
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@PkgName", pack.PkgName);
            insertCommand.Parameters.AddWithValue("@PkgDesc", pack.PkgDesc);
            insertCommand.Parameters.AddWithValue("@PkgStartDate", pack.PkgStartDate);
            insertCommand.Parameters.AddWithValue("@PkgEndDate", pack.PkgEndDate);
            insertCommand.Parameters.AddWithValue("@PkgBasePrice", pack.PkgBasePrice);
            insertCommand.Parameters.AddWithValue("@PkgAgencyCommission", pack.PkgAgencyCommission);
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
                                     "    PkgDesc = @NewPkgDesc, " +
                                     "    PkgStartDate = @NewPkgStartDate, " +
                                     "    PkgEndDate = @NewPkgEndDate, " +
                                     "    PkgBasePrice = @NewPkgBasePrice, " +
                                     "    PkgAgencyCommission = @NewPkgAgencyCommission " +
                                     "WHERE PackageId = @PackageId " +
                                     "  AND PkgName = @OldPkgName " +
                                     "  AND PkgDesc = @OldPkgDesc " +
                                     "  AND PkgStartDate = @OldPkgStartDate " +
                                     "  AND PkgEndDate = @OldPkgEndDate " +
                                     "  AND PkgBasePrice = @OldPkgBasePrice " +
                                     "  AND PkgAgencyCommission = @OldPkgAgencyCommission";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@OldPkgName", oldPack.PkgName);
            updateCommand.Parameters.AddWithValue("@OldPkgDesc", oldPack.PkgDesc);
            updateCommand.Parameters.AddWithValue("@OldPkgStartDate", oldPack.PkgStartDate);
            updateCommand.Parameters.AddWithValue("@OldPkgEndDate", oldPack.PkgEndDate);
            updateCommand.Parameters.AddWithValue("@OldPkgBasePrice", oldPack.PkgBasePrice);
            updateCommand.Parameters.AddWithValue("@OldPkgAgencyCommission", oldPack.PkgAgencyCommission);
            updateCommand.Parameters.AddWithValue("@PackageId", oldPack.PackageId);
            updateCommand.Parameters.AddWithValue("@NewPkgName", newPack.PkgName);
            updateCommand.Parameters.AddWithValue("@NewPkgDesc", newPack.PkgDesc);
            updateCommand.Parameters.AddWithValue("@NewPkgStartDate", newPack.PkgStartDate);
            updateCommand.Parameters.AddWithValue("@NewPkgEndDate", newPack.PkgEndDate);
            updateCommand.Parameters.AddWithValue("@NewPkgBasePrice", newPack.PkgBasePrice);
            updateCommand.Parameters.AddWithValue("@NewPkgAgencyCommission", newPack.PkgAgencyCommission);
            try
            {
                connection.Open();
                int indicator = updateCommand.ExecuteNonQuery();
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
                                     "  AND PkgAgencyCommission = @PkgAgencyCommission";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@PackageId", pack.PackageId);
            deleteCommand.Parameters.AddWithValue("@PkgName", pack.PkgName);
            deleteCommand.Parameters.AddWithValue("@PkgDesc", pack.PkgDesc);
            deleteCommand.Parameters.AddWithValue("@PkgStartDate", pack.PkgStartDate);
            deleteCommand.Parameters.AddWithValue("@PkgEndDate", pack.PkgEndDate);
            deleteCommand.Parameters.AddWithValue("@PkgBasePrice", pack.PkgBasePrice);
            deleteCommand.Parameters.AddWithValue("@PkgAgencyCommission", pack.PkgAgencyCommission);

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
    }
    //public static List<Product> SearchProducts(string searchIndex)
    //{
    //    //We need a suppliers list to return; either a list of suppliers or an empty list
    //    List<Product> products = new List<Product>();
    //    //get the connection and make a new select statement
    //    SqlConnection connection = TravelExpertsCommon.GetConnection();
    //    SqlCommand selectCommand = new SqlCommand(SearchAll, connection);
    //    selectCommand.Parameters.AddWithValue("@searchIndex", searchIndex);

    //    //Using will auto close the connection once the block is ended
    //    using (connection)
    //    {
    //        //try in case of errors and re-throw them to the UI
    //        try
    //        {
    //            connection.Open();

    //            SqlDataReader reader = selectCommand.ExecuteReader();
    //            while (reader.Read())
    //            {
    //                //build a new Product Object for each returned product
    //                Product product = new Product
    //                {
    //                    ProductId = (int)reader["ProductId"],
    //                    ProdName = reader["ProdName"].ToString()
    //                };
    //                //add the supplier to the list
    //                products.Add(product);
    //            }
    //        }
    //        catch (Exception ex)    //catch all exceptions and re-throw them
    //        {
    //            products = null;   //an error occurred so lets not continue
    //            throw ex;
    //        }
    //        finally
    //        {
    //            connection.Close();
    //        }
    //    }   //end of the using statement
    //    return products;
    //}
}
