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
    public static class PackagesProductsSuppliersTable
    {
        //SQL STATEMENTS\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private const string DeletePkgStmt = "DELETE Packages_Products_Suppliers " +
                                             "WHERE PackageId = @PackageId " +
                                             "AND PackageID = @PackageID";
        //Statement for AddSupplier()
        private const string InsertStmt = "INSERT INTO Packages_Products_Suppliers " +
                                          "(PackageId, ProductSupplierId) " +
                                          "VALUES(@PackageId, @ProductSupplierID)";

        private const string DeleteStmt = "DELETE Packages_Products_Suppliers " +
                                          "WHERE PackageId = @PackageId " +
                                          "AND ProductSupplierId = @ProductSupplierID";

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        //Static Method to add a new Supplier
        public static bool AddSupplier(int pkgId, ProductSupplier prodSup, SqlTransaction transaction = null)
        {
            //get the connection and make a new select statement
            SqlCommand command = TravelExpertsCommon.GetCommand(InsertStmt);
            command.Transaction = transaction;

            //add the Supplier Parameters to the SQL Insert Command
            command.Parameters.AddWithValue("@PackageId", pkgId);
            command.Parameters.AddWithValue("@ProductSupplierId", prodSup.ProductSupplierId);

            return TravelExpertsCommon.PerformNonQuery(command);
        }

        public static bool DeletePkgProdSup(int pkgId, ProductSupplier prodSup, SqlTransaction transaction = null)
        {
            SqlCommand command = TravelExpertsCommon.GetCommand(DeleteStmt);
            command.Transaction = transaction;

            //add the Supplier Parameters to the SQL Insert Command
            command.Parameters.AddWithValue("@PackageId", pkgId);
            command.Parameters.AddWithValue("@ProductSupplierId", prodSup.ProductSupplierId);

            return TravelExpertsCommon.PerformNonQuery(command);
        }

        public static bool DeletePkgProdSup(int pkgId, SqlTransaction transaction = null)
        {
            SqlCommand command = TravelExpertsCommon.GetCommand(DeletePkgStmt);
            command.Transaction = transaction;
            //add the Supplier Parameters to the SQL Insert Command
            command.Parameters.AddWithValue("@PackageId", pkgId);

            return TravelExpertsCommon.PerformNonQuery(command);
        }
    }
}
