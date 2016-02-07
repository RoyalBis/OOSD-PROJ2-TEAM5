using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

/**********************************************************************
Title:                PackagesTable.cs  
 Project:          Travel Experts Desktop App
Authors:         Royal Bissell, Kevin Liao, Annie Ali, Lee Harrold
Class:               OOSD Fall 2015 
Date:               2016/02/07
Description:  Data Access Class for Quering the Packages Table in the Travel Experts Database
**********************************************************************/

namespace TravelExpertsDB
{
    /// <summary>
    /// TravelExperts Packages Table Access Class
    /// </summary>
    public static class PackagesTable
    {
        #region Query Strings
        //SQL STATEMENTS\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //Statement for GetAllPackages()
        private const string GetAllStmt = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission, PkgImage " +
                                                                             "FROM Packages ORDER BY PackageId";
        
        //Statement for GetPackage()
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
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        #endregion

        #region Queries
        /// <summary>
        /// Get all Packages
        /// </summary>
        /// <returns>PackageList</returns>
        public static PackageList GetAllPackages()
        {
            //need a PackageList Variable
            PackageList packages = new PackageList();    

            //Get the command
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
                        //build each package with the common CreatePackage Method
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

        /// <summary>
        /// Search All Packages Based on a Package Id
        /// </summary>
        /// <param name="packageId">int packageId</param>
        /// <returns>Package</returns>
        public static Package SearchPackage(int packageId)
        {
            //return the command for the query
            SqlCommand command = TravelExpertsCommon.GetCommand(GetStmt);
            //paramaterize the command
            command.Parameters.AddWithValue("@PackageId", packageId);
            try
            {
                command.Connection.Open();
                //will only get one becuase pkgId is the uniqueq key
                SqlDataReader packageReader = command.ExecuteReader(CommandBehavior.SingleRow);
                if (packageReader.Read())
                {
                    //build it will the common create package method 
                    return CreatePackage(packageReader);
                }
                else
                {
                    //no results.
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                //either way close the connection
                command.Connection.Close();
            }
        }

        /// <summary>
        /// Insert a new Package into the Database
        /// </summary>
        /// <param name="pkg">Package</param>
        /// <returns>int PackageId, the new packages id</returns>
        public static int AddPackage(Package pkg) //add product method
        {
            //get the insert command
            SqlCommand command = TravelExpertsCommon.GetCommand(InsertStmt);
            //parameterize the command
            command.Parameters.AddWithValue("@PkgName", pkg.PkgName);
            command.Parameters.AddWithValue("@PkgDesc", pkg.PkgDesc);
            command.Parameters.AddWithValue("@PkgStartDate", pkg.PkgStartDate);
            command.Parameters.AddWithValue("@PkgEndDate", pkg.PkgEndDate);
            command.Parameters.AddWithValue("@PkgBasePrice", pkg.PkgBasePrice);
            command.Parameters.AddWithValue("@PkgAgencyCommission", pkg.PkgAgencyCommission);
            //PkgImage can be null
            if ( pkg.PkgImage == null )
            {
                command.Parameters.AddWithValue("@PkgImage", new byte [0] );
            }
            else
            {
                command.Parameters.AddWithValue("@PkgImage", pkg.PkgImage);
            }
            
            //call common Perform Query Command
            if ( TravelExpertsCommon.PerformNonQuery(command) )
            {
                //next command to get the newly inserted Package
                SqlCommand commCurr = TravelExpertsCommon.GetCommand(GetCurrentStmt);
                //Using will auto close the connection once the block is ended
                using (commCurr.Connection)
                {
                    //try in case of errors and re-throw them to the UI
                    try
                    {
                        commCurr.Connection.Open();

                        int packageId = int.Parse(commCurr.ExecuteScalar().ToString()); //first col of the row is selected
                        return packageId; //just return the new packageid
                    }
                    catch (Exception ex)    //catch all exceptions and re-throw them
                    {
                        throw ex;
                    }
                }   //end of the using statement
            }
            else
            {
                //-1 indicates that no pkg was inserted and it failed.
                return -1;
            }
        }

        /// <summary>
        /// Update an existing Package in the database
        /// </summary>
        /// <param name="oldPack">Package to Update</param>
        /// <param name="newPack">New Package</param>
        /// <returns>true if successful</returns>
        public static bool UpdatePackage(Package oldPack, Package newPack) //update method
        {
            //get the update command
            SqlCommand command = TravelExpertsCommon.GetCommand(UpdateStmt);
            //parameterize the command
            command.Parameters.AddWithValue("@OldPkgName", oldPack.PkgName);
            command.Parameters.AddWithValue("@OldPkgDesc", oldPack.PkgDesc);
            command.Parameters.AddWithValue("@OldPkgStartDate", oldPack.PkgStartDate);
            command.Parameters.AddWithValue("@OldPkgEndDate", oldPack.PkgEndDate);
            command.Parameters.AddWithValue("@OldPkgBasePrice", oldPack.PkgBasePrice);
            command.Parameters.AddWithValue("@OldPkgAgencyCommission", oldPack.PkgAgencyCommission);
            //PkgImage is allowed to be null
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

            //just perform the query and return true or false.
            return TravelExpertsCommon.PerformNonQuery(command);
        }

        /// <summary>
        /// Delete a Package from the database
        /// </summary>
        /// <param name="pkg">Package</param>
        /// <returns>true if delete was successful</returns>
        public static bool DeletePackage(Package pkg) //delete method
        {
            //get the delete command
            SqlCommand command = TravelExpertsCommon.GetCommand(DeleteStmt);
            //parameterize the command
            command.Parameters.AddWithValue("@PackageId", pkg.PackageId);
            command.Parameters.AddWithValue("@PkgName", pkg.PkgName);
            command.Parameters.AddWithValue("@PkgDesc", pkg.PkgDesc);
            command.Parameters.AddWithValue("@PkgStartDate", pkg.PkgStartDate);
            command.Parameters.AddWithValue("@PkgEndDate", pkg.PkgEndDate);
            command.Parameters.AddWithValue("@PkgBasePrice", pkg.PkgBasePrice);
            command.Parameters.AddWithValue("@PkgAgencyCommission", pkg.PkgAgencyCommission);
            command.Parameters.AddWithValue("@PkgImage", pkg.PkgImage);

            //just perform the query and return the result
            return TravelExpertsCommon.PerformNonQuery(command);
        }
        #endregion

        /// <summary>
        /// Method to create a Package from a database query
        /// </summary>
        /// <param name="reader">SqlDataReader, result of a query</param>
        /// <returns>Package</returns>
        private static Package CreatePackage(SqlDataReader reader)
        {
            Package pkg = new Package();
            pkg.PackageId = (int)reader["PackageId"];
            pkg.PkgName = reader["PkgName"].ToString();
            pkg.PkgDesc = reader["PkgDesc"].ToString();
            pkg.PkgBasePrice = (decimal)reader["PkgBasePrice"];
            pkg.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];
            pkg.PkgStartDate = (DateTime)reader["PkgStartDate"];
            pkg.PkgEndDate = (DateTime)reader["PkgEndDate"];
            if (reader["PkgImage"] is DBNull)
            {
                pkg.PkgImage = null;
            }
            else
            {
                pkg.PkgImage = (byte[])reader["PkgImage"];
            }
            return pkg;
        }
    }
}
