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
        private const string InsertSupplierStmt = "INSERT INTO Suppliers " +
                                                  "(SupplierId, SupName) " +
                                                  "VALUES(@SupplierId, @SupName)";

        //Statement for UpdateSupplier()
        private const string UpdateSupplierStmt = "UPDATE Suppliers " +
                                                  "SET SupName = @NewSupName " +
                                                  "WHERE SupplierId = @OldSupplierId " +
                                                  "AND SupName = @OldSupName";
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\



        //Static Method to return a list of all the Possible Suppliers
        public static List<Supplier> GetAllSuppliers()
        {
            //We need a suppliers list to return; either a list of suppliers or an empty list
            List<Supplier> suppliers = new List<Supplier>();
            //get the connection and make a new select statement
            SqlConnection connection = new SqlConnection();
            SqlCommand selectCommand = new SqlCommand(GetAllStmt, connection);

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
                        //build a new Supplier Object for each returned Supplier
                        Supplier supplier = new Supplier
                        {
                            SupplierId = (int)reader["SupplierId"],
                            SupName = reader["SupName"].ToString()
                        };
                        //add the supplier to the list
                        suppliers.Add(supplier);
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

        //Static Method to return one supplier from a SupplierId
        public static Supplier GetSupplier(int supplierId)
        {
            //We need a supplier to return or null
            Supplier supplier = null;
            //get the connection and make a new select statement
            SqlConnection connection = new SqlConnection();
            SqlCommand selectCommand = new SqlCommand(GetStmt, connection);
            //add the supplierId Parameter to the SQL Command
            selectCommand.Parameters.AddWithValue("@SupplierId", supplierId);

            //Using will auto close the connection once the block is ended
            using (connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    connection.Open();

                    SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                    while (reader.Read())
                    {
                        //build a new Supplier Object
                        supplier = new Supplier
                        {
                            SupplierId = (int)reader["SupplierId"],
                            SupName = reader["SupName"].ToString()
                        };
                    }
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement

            return supplier;
        }

        //Static Method to return a list of all the Suppliers of a specific product
        public static List<Supplier> GetSuppliersofProduct(int productId)
        {
            //We need a suppliers list to return; either a list of suppliers or an empty list
            List<Supplier> suppliers = new List<Supplier>();
            //get the connection and make a new select statement
            SqlConnection connection = new SqlConnection();
            SqlCommand selectCommand = new SqlCommand(GetAllOfProductStmt, connection);
            selectCommand.Parameters.AddWithValue("@ProductId","productId");

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
                        //build a new Supplier Object for each returned Supplier
                        Supplier supplier = new Supplier
                        {
                            SupplierId = (int)reader["SupplierId"],
                            SupName = reader["SupName"].ToString()
                        };
                        //add the supplier to the list
                        suppliers.Add(supplier);
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
            SqlConnection connection = new SqlConnection();
            SqlCommand insertCommand = new SqlCommand(InsertSupplierStmt, connection);
            //add the Supplier Parameters to the SQL Insert Command
            insertCommand.Parameters.AddWithValue("@SupplierId", sup.SupplierId);
            insertCommand.Parameters.AddWithValue("@SupName", sup.SupName);

            //Using will auto close the connection once the block is ended
            using (connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    connection.Open();

                    int nr = insertCommand.ExecuteNonQuery();   //nr is the number of rows that are affected
                    if ( nr != 1 )  //number of rows affected should be 1
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

        //Static Method to update an existing Supplier
        public static bool UpdateSupplier(Supplier newSup, Supplier oldSup)
        {
            //get the connection and make a new select statement
            SqlConnection connection = new SqlConnection();
            SqlCommand updateCommand = new SqlCommand(UpdateSupplierStmt, connection);
            //add the Supplier Parameters to the SQL update Command
            updateCommand.Parameters.AddWithValue("@NewSupName", newSup.SupName);
            updateCommand.Parameters.AddWithValue("@OldSupplierId", oldSup.SupplierId);
            updateCommand.Parameters.AddWithValue("@OldSupName", oldSup.SupName);

            //Using will auto close the connection once the block is ended
            using (connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    connection.Open();

                    int nr = updateCommand.ExecuteNonQuery();   //nr is the number of rows that are affected
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
