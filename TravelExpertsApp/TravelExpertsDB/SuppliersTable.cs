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
    //Author: Royal
    public static class SuppliersTable
    {
        #region Query Strings
        //SQL STATEMENTS\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //Statement for GetAllSuppliers()
        private const string GetAllStmt = "SELECT SupplierId, SupName " +
                                          "FROM Suppliers";

        //Statement for GetSupplier()
        private const string GetStmt = "SELECT SupplierId, SupName " +
                                       "FROM Suppliers " +
                                       "WHERE SupplierId = @SupplierId";

        //Statement for GetSuppliersofProduct()
        private const string GetAllOfProductStmt = "SELECT SupplierID, SupName " +
                                                   "FROM Suppliers " +
                                                   "INNER JOIN Products_Suppliers " +
                                                   "WHERE ProductId = @ProductId";

        //Statement for AddSupplier()
        private const string InsertStmt = "INSERT INTO Suppliers " +
                                                  "(SupplierId, SupName) " +
                                                  "VALUES(@SupplierId, @SupName)";

        //Statement for UpdateSupplier()
        private const string UpdateStmt = "UPDATE Suppliers " +
                                                  "SET SupName = @NewSupName " +
                                                  "WHERE SupplierId = @OldSupplierId " +
                                                  "AND SupName = @OldSupName";

        //Statement for SearchAllSuppliers()
        private const string SearchAll = "SELECT supplierId, SupName " +
                                         "FROM suppliers " +
                                         "WHERE supplierId " +
                                         "LIKE  '%' + @searchIndex + '%' " +
                                         "OR SupName LIKE '%' + @searchIndex  ";

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        #endregion

        #region Database Queries
        //Static Method to return a list of all the Possible Suppliers
        public static List<Supplier> GetAllSuppliers()
        {
            //We need a suppliers list to return; either a list of suppliers or an empty list
            List<Supplier> suppliers = new List<Supplier>();

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
                        suppliers.Add( CreateSupplier(reader) );
                    }
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
            return suppliers;
        }

        //Static Method to return one supplier from a SupplierId
        public static Supplier GetSupplier(int supplierId)
        {
            //We need a suppliers list to return; either a list of suppliers or an empty list
            List<Supplier> suppliers = new List<Supplier>();

            SqlCommand command = TravelExpertsCommon.GetCommand(GetStmt);
            //add the supplierId Parameter to the SQL Command
            command.Parameters.AddWithValue("@SupplierId", supplierId);

            //Using will auto close the connection once the block is ended
            using (command.Connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    command.Connection.Open();

                    SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                    while (reader.Read())
                    {
                        return CreateSupplier(reader);
                    }
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
            return null;
        }

        //Static Method to return a list of all the Suppliers of a specific product
        public static List<Supplier> GetSuppliersofProduct(int productId)
        {
            //We need a suppliers list to return; either a list of suppliers or an empty list
            List<Supplier> suppliers = new List<Supplier>();

            SqlCommand command = TravelExpertsCommon.GetCommand(GetAllOfProductStmt);
            command.Parameters.AddWithValue("@ProductId","productId");

            //Using will auto close the connection once the block is ended
            using (command.Connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    command.Connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        suppliers.Add(CreateSupplier(reader));
                    }
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    suppliers = null;   //an error occurred so lets not continue
                    throw ex;
                }
            }   //end of the using statement
            return suppliers;
        }

        //Static Method to add a new Supplier
        public static bool AddSupplier(Supplier sup)
        {
            //get the connection and make a new select statement
            SqlCommand command = TravelExpertsCommon.GetCommand(InsertStmt);
            //add the Supplier Parameters to the SQL Insert Command
            command.Parameters.AddWithValue("@SupplierId", sup.SupplierId);
            command.Parameters.AddWithValue("@SupName", sup.SupName);

            return TravelExpertsCommon.PerformNonQuery(command);
        }

        //Static Method to update an existing Supplier
        public static bool UpdateSupplier(Supplier newSup, Supplier oldSup)
        {
            //get the connection and make a new select statement
            SqlCommand command = TravelExpertsCommon.GetCommand(UpdateStmt);
            //add the Supplier Parameters to the SQL update Command
            command.Parameters.AddWithValue("@NewSupName", newSup.SupName);
            command.Parameters.AddWithValue("@OldSupplierId", oldSup.SupplierId);
            command.Parameters.AddWithValue("@OldSupName", oldSup.SupName);

            return TravelExpertsCommon.PerformNonQuery(command);
        }

        public static List<Supplier> SearchAllSuppliers(string searchIndex)
        {
            //We need a suppliers list to return; either a list of suppliers or an empty list
            List<Supplier> suppliers = new List<Supplier>();
            //get the connection and make a new select statement
            SqlCommand command = TravelExpertsCommon.GetCommand(SearchAll);
            command.Parameters.AddWithValue("@searchIndex", searchIndex);

            //Using will auto close the connection once the block is ended
            using (command.Connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    command.Connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        //build a new Product Object for each returned product and add it to the list
                        suppliers.Add(CreateSupplier(reader));
                    }
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
            return suppliers;
        }
        #endregion

        internal static Supplier CreateSupplier(SqlDataReader reader)
        {
            //build a new Supplier Object for each returned Supplier
            Supplier supplier = new Supplier();
            supplier.SupplierId = (int)reader["SupplierId"];
            supplier.SupName = reader["SupName"].ToString();
            //add the supplier to the list
            return supplier;
        }
    }
}
