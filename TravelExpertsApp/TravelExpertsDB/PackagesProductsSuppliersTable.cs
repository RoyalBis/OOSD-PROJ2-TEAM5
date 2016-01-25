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
            SqlCommand command;
            //get the connection and make a new select statement
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            if ( transaction != null )
            {
                command = new SqlCommand(InsertStmt, connection, transaction);
            }
            else
            {
                command = new SqlCommand(InsertStmt, connection);
            }
            //add the Supplier Parameters to the SQL Insert Command
            command.Parameters.AddWithValue("@PackageId", pkgId);
            command.Parameters.AddWithValue("@ProductSupplierId", prodSup.ProductSupplierId);

            //Using will auto close the connection once the block is ended
            using (connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    connection.Open();

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

        public static bool DeletePkgProdSup(int pkgId, ProductSupplier prodSup, SqlTransaction transaction = null)
        {
            SqlCommand command;
            //get the connection and make a new select statement
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            if (transaction != null)
            {
                command = new SqlCommand(DeleteStmt, connection, transaction);
            }
            else
            {
                command = new SqlCommand(DeleteStmt, connection);
            }
            //add the Supplier Parameters to the SQL Insert Command
            command.Parameters.AddWithValue("@PackageId", pkgId);
            command.Parameters.AddWithValue("@ProductSupplierId", prodSup.ProductSupplierId);

            //Using will auto close the connection once the block is ended
            using (connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    connection.Open();

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

        public static bool DeletePkgProdSup(int pkgId, SqlTransaction transaction = null)
        {
            SqlCommand command;
            //get the connection and make a new select statement
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            if (transaction != null)
            {
                command = new SqlCommand(DeletePkgStmt, connection, transaction);
            }
            else
            {
                command = new SqlCommand(DeletePkgStmt, connection);
            }
            //add the Supplier Parameters to the SQL Insert Command
            command.Parameters.AddWithValue("@PackageId", pkgId);

            //Using will auto close the connection once the block is ended
            using (connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    connection.Open();

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
    }
}
