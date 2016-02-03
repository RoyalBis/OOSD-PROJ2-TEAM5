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

    //TODO: Manage NULLS IN THE DATABASE

    public static class PackagesTable
    {
        #region Query Strings
        //SQL STATEMENTS\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //Statement for GetAllPackages()
        private const string GetAllStmt = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission, PkgImage " +
                                          "FROM Packages ORDER BY PackageId";
        
        //Statement for GetSupplier()
        private const string GetStmt = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission, PkgImage " +
                                       "FROM Packages " +
                                       "WHERE PackageId = @PackageId";

        //Statement for AddPackage()
        private const string InsertStmt = "INSERT INTO Packages " +
                                          "(PkgName, PkgDesc, PkgStartDate, PkgEndDate, PkgBasePrice, PkgAgencyCommission, PkgImage) " +
                                          "Values(@PkgName, @PkgDesc, @PkgStartDate, @PkgEndDate, @PkgBasePrice, @PkgAgencyCommission, @PkgImage)";

        //Statement for Getting the recently added package
        private const string GetCurrentStmt = "SELECT IDENT_CURRENT('Packages') " +
                                              "FROM Packages";
        
        //Statement for UpdatePackage()
        private const string UpdateStmt = "UPDATE Packages " +
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
        //Statement for DeletePackage()
        private const string DeleteStmt = "DELETE Packages " +
                                               "WHERE PackageId = @PackageId " +
                                               "AND PkgName = @PkgName " +
                                               "AND PkgDesc = @PkgDesc " +
                                               "AND PkgStartDate = @PkgStartDate " +
                                               "AND PkgEndDate = @PkgEndDate " +
                                               "AND PkgBasePrice = @PkgBasePrice " +
                                               "AND PkgAgencyCommission = @PkgAgencyCommission " +
                                               "AND PkgImage = @PkgImage";

        //Statement for SearchAllSuppliers()
        private const string SearchAll = "SELECT supplierId, SupName " +
                                         "FROM suppliers " +
                                         "WHERE supplierId " +
                                         "LIKE  '%' + @searchIndex + '%' " +
                                         "OR SupName LIKE '%' + @searchIndex";
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        #endregion

        public static PackageList GetAllPackages()
        {
            PackageList packages = new PackageList();    

            SqlCommand command = TravelExpertsCommon.GetCommand(GetAllStmt);
 
            //Using will auto close the connection once the block is ended
            using (command.Connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    command.Connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while ( reader.Read() )
                    {
                        packages.Add(CreatePackage(reader));
                    }
                    return packages;
                }
                catch ( Exception ex ) //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }

        public static Package SearchPackage(int packageId) //Search method
        {
            SqlCommand command = TravelExpertsCommon.GetCommand(GetStmt);
            command.Parameters.AddWithValue("@PackageId", packageId);
            try
            {
                command.Connection.Open();
                SqlDataReader packageReader = command.ExecuteReader(CommandBehavior.SingleRow);
                if (packageReader.Read())
                {
                    return CreatePackage(packageReader);
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
                command.Connection.Close();
            }
        }

        public static int AddPackage(Package pack) //add product method
        {
            SqlCommand command = TravelExpertsCommon.GetCommand(InsertStmt);
            command.Parameters.AddWithValue("@PkgName", pack.PkgName);
            command.Parameters.AddWithValue("@PkgDesc", pack.PkgDesc);
            command.Parameters.AddWithValue("@PkgStartDate", pack.PkgStartDate);
            command.Parameters.AddWithValue("@PkgEndDate", pack.PkgEndDate);
            command.Parameters.AddWithValue("@PkgBasePrice", pack.PkgBasePrice);
            command.Parameters.AddWithValue("@PkgAgencyCommission", pack.PkgAgencyCommission);
            if ( pack.PkgImage == null )
            {
                command.Parameters.AddWithValue("@PkgImage", new byte [0] );
            }
            else
            {
                command.Parameters.AddWithValue("@PkgImage", pack.PkgImage);
            }

            if ( TravelExpertsCommon.PerformNonQuery(command) )
            {
                SqlCommand commCurr = TravelExpertsCommon.GetCommand(GetCurrentStmt);
                //Using will auto close the connection once the block is ended
                using (commCurr.Connection)
                {
                    //try in case of errors and re-throw them to the UI
                    try
                    {
                        commCurr.Connection.Open();

                        int packageId = int.Parse(commCurr.ExecuteScalar().ToString()); //first col of the row is selected
                        return packageId;
                    }
                    catch (Exception ex)    //catch all exceptions and re-throw them
                    {
                        throw ex;
                    }
                }   //end of the using statement
            }
            else
            {
                return -1;
            }
        }

        public static bool UpdatePackage(Package oldPack, Package newPack) //update method
        {
            SqlCommand command = TravelExpertsCommon.GetCommand(UpdateStmt);
            command.Parameters.AddWithValue("@OldPkgName", oldPack.PkgName);
            command.Parameters.AddWithValue("@OldPkgDesc", oldPack.PkgDesc);
            command.Parameters.AddWithValue("@OldPkgStartDate", oldPack.PkgStartDate);
            command.Parameters.AddWithValue("@OldPkgEndDate", oldPack.PkgEndDate);
            command.Parameters.AddWithValue("@OldPkgBasePrice", oldPack.PkgBasePrice);
            command.Parameters.AddWithValue("@OldPkgAgencyCommission", oldPack.PkgAgencyCommission);
            if ( oldPack.PkgImage == null )
            {
                command.Parameters.AddWithValue("@OldPkgImage", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("@OldPkgImage", oldPack.PkgImage);
            }
            command.Parameters.AddWithValue("@PackageId", oldPack.PackageId);
            command.Parameters.AddWithValue("@NewPkgName", newPack.PkgName);
            command.Parameters.AddWithValue("@NewPkgDesc", newPack.PkgDesc);
            command.Parameters.AddWithValue("@NewPkgStartDate", newPack.PkgStartDate);
            command.Parameters.AddWithValue("@NewPkgEndDate", newPack.PkgEndDate);
            command.Parameters.AddWithValue("@NewPkgBasePrice", newPack.PkgBasePrice);
            command.Parameters.AddWithValue("@NewPkgAgencyCommission", newPack.PkgAgencyCommission);
            command.Parameters.AddWithValue("@NewPkgImage", newPack.PkgImage);

            return TravelExpertsCommon.PerformNonQuery(command);
        }

        public static bool DeletePackage(Package pack) //delete method
        {
            SqlCommand command = TravelExpertsCommon.GetCommand(DeleteStmt);
            command.Parameters.AddWithValue("@PackageId", pack.PackageId);
            command.Parameters.AddWithValue("@PkgName", pack.PkgName);
            command.Parameters.AddWithValue("@PkgDesc", pack.PkgDesc);
            command.Parameters.AddWithValue("@PkgStartDate", pack.PkgStartDate);
            command.Parameters.AddWithValue("@PkgEndDate", pack.PkgEndDate);
            command.Parameters.AddWithValue("@PkgBasePrice", pack.PkgBasePrice);
            command.Parameters.AddWithValue("@PkgAgencyCommission", pack.PkgAgencyCommission);
            command.Parameters.AddWithValue("@PkgImage", pack.PkgImage);

            return TravelExpertsCommon.PerformNonQuery(command);
        }

        public static List<Package> SearchAllPackages(string searchIndex)
        {
            //We need a suppliers list to return; either a list of suppliers or an empty list
            List<Package> packages = new List<Package>();
            //get the connection and make a new select statement
            SqlCommand command = TravelExpertsCommon.GetCommand(SearchAll);
            command.Parameters.AddWithValue("@searchIndex", searchIndex);

            SqlDataReader reader = TravelExpertsCommon.PerformQuery(command);
            while (reader.Read())
            {
                //build a new Product Object for each returned product
                //add the packages to the list
                packages.Add(CreatePackage(reader));
            }
            return packages;
        }

        private static Package CreatePackage(SqlDataReader reader)
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
            return pack;
        }
    }
}
