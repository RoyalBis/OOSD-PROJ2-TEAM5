using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace TravelExpertsDB
{
    /// <summary>
    /// TravelExperts Packages_Products_Suppliers Table Access Class
    /// </summary>
    public static class PackagesProductsSuppliersTable
    {

        #region Query Strings
        //SQL STATEMENTS\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //Statment to delete all package product suppliers of a specific package
        private const string DeletePkgStmt = "DELETE Packages_Products_Suppliers " +
                                             "WHERE PackageId = @PackageId";
        //Statement to add a product supplier
        private const string InsertStmt = "INSERT INTO Packages_Products_Suppliers " +
                                          "(PackageId, ProductSupplierId) " +
                                          "VALUES(@PackageId, @ProductSupplierID)";

        //statment to delte a specific package product supplier
        private const string DeleteStmt = "DELETE Packages_Products_Suppliers " +
                                          "WHERE PackageId = @PackageId " +
                                          "AND ProductSupplierId = @ProductSupplierID";

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        #endregion

        #region Queries

        /// <summary>
        /// Add a PackageProductSupplier
        /// </summary>
        /// <param name="pkgId">int PackageId</param>
        /// <param name="prodSup">ProductSupplier</param>
        /// <returns>true if insert successful</returns>
        public static bool AddPkgProdSup(int pkgId, ProductSupplier prodSup)
        {
            //get the connection and make a new insert statement
            SqlCommand command = TravelExpertsCommon.GetCommand(InsertStmt);

            //add the  Parameters to the SQL Insert Command
            command.Parameters.AddWithValue("@PackageId", pkgId);
            command.Parameters.AddWithValue("@ProductSupplierId", prodSup.ProductSupplierId);

            //use the common TravelExperts perform nonquery
            return TravelExpertsCommon.PerformNonQuery(command);
        }

        /// <summary>
        /// Delete a PackageProductSupplier from the Database
        /// </summary>
        /// <param name="pkgId">int PackageId</param>
        /// <param name="prodSup">ProductSupplier</param>
        /// <returns>true if the delete was successful</returns>
        public static bool DeletePkgProdSup(int pkgId, ProductSupplier prodSup)
        {
            //get the connection and make a new delete statement
            SqlCommand command = TravelExpertsCommon.GetCommand(DeleteStmt);

            //add the Supplier Parameters to the SQL Insert Command
            command.Parameters.AddWithValue("@PackageId", pkgId);
            command.Parameters.AddWithValue("@ProductSupplierId", prodSup.ProductSupplierId);

            //use the common TravelExperts method perform nonquery
            return TravelExpertsCommon.PerformNonQuery(command);
        }

        /// <summary>
        /// Delete the All Product Suppliers from a Package
        /// </summary>
        /// <param name="pkgId">int PackageId</param>
        /// <returns>true if the delete was successful</returns>
        public static bool DeletePkgProdSup(int pkgId)
        {
            //get the connection and make a new delete statement
            SqlCommand command = TravelExpertsCommon.GetCommand(DeletePkgStmt);

            //add the Supplier Parameters to the SQL Insert Command
            command.Parameters.AddWithValue("@PackageId", pkgId);

            //use the common TravelExperts method perform nonquery
            return TravelExpertsCommon.PerformNonQuery(command);
        }
        #endregion

    }
}
