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
    /// TravelExperts Suppliers Table Access Class
    /// </summary>
    public static class SuppliersTable
    {
        #region Query Strings
        //SQL STATEMENTS\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //Statement for GetAllSuppliers()
        private const string GetAllStmt = "SELECT SupplierId, SupName " +
                                                                              "FROM Suppliers " +
                                                                              "ORDER BY SupplierId";

        //Statement for GetSupplier()
        private const string GetStmt = "SELECT SupplierId, SupName " +
                                                                        "FROM Suppliers " +
                                                                        "WHERE SupplierId = @SupplierId";

        //Statement for AddPkgProdSup()
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
                                                                         "WHERE supplierId LIKE @searchIndex + '%' " +
                                                                         "OR SupName LIKE '%' + @searchIndex  + '%' ";

        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        #endregion

        #region Database Queries
        /// <summary>
        /// Get All Suppliers
        /// </summary>
        /// <returns>List of Suppliers</returns>
        public static List<Supplier> GetAllSuppliers()
        {
            //We need a suppliers list to return; either a list of suppliers or an empty list
            List<Supplier> suppliers = new List<Supplier>();
            //get the command
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
                        //build each supplier and add them to the list
                        suppliers.Add( CreateSupplier(reader) );
                    }
                    //return the suppliers, empty if none were returned
                    return suppliers;
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }

        /// <summary>
        /// Get the supplier that matches specified supplierId
        /// </summary>
        /// <param name="supplierId"></param>
        /// <returns>Supplier</returns>
        public static Supplier GetSupplier(int supplierId)
        {
            //We need a suppliers list to return; either a list of suppliers or an empty list
            List<Supplier> suppliers = new List<Supplier>();
            //get the command
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
                        //return the  single retrieved Supplier
                        return CreateSupplier(reader);
                    }
                    return null;    //we got nothing, so just return null
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }

        /// <summary>
        /// Insert new Supplier into the database
        /// </summary>
        /// <param name="sup">Supplier</param>
        /// <returns>true if insert was successful</returns>
        public static bool AddSupplier(Supplier sup)
        {
            //get the connection and make a new select statement
            SqlCommand command = TravelExpertsCommon.GetCommand(InsertStmt);
            //add the Supplier Parameters to the SQL Insert Command
            command.Parameters.AddWithValue("@SupplierId", sup.SupplierId);
            command.Parameters.AddWithValue("@SupName", sup.SupName);

            //just perform the query and return the result
            return TravelExpertsCommon.PerformNonQuery(command);
        }

        /// <summary>
        /// Update an Existing Supplier into the database
        /// </summary>
        /// <param name="newSup">Supplier, New</param>
        /// <param name="oldSup">Supplier, Existing</param>
        /// <returns>true if update was successful</returns>
        public static bool UpdateSupplier(Supplier newSup, Supplier oldSup)
        {
            //get the connection and make a new select statement
            SqlCommand command = TravelExpertsCommon.GetCommand(UpdateStmt);
            //add the Supplier Parameters to the SQL update Command
            command.Parameters.AddWithValue("@NewSupName", newSup.SupName);
            command.Parameters.AddWithValue("@OldSupplierId", oldSup.SupplierId);
            command.Parameters.AddWithValue("@OldSupName", oldSup.SupName);

            //just perform the query and returnt the result
            return TravelExpertsCommon.PerformNonQuery(command);
        }

        /// <summary>
        /// Search all Suppliers based on a search string and return a list of matches
        /// </summary>
        /// <param name="searchIndex">string</param>
        /// <returns>List of Suppliers</returns>
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
                    return suppliers;
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }
        #endregion

        /// <summary>
        /// Common method to Create Suppliers from a Database Query
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
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
