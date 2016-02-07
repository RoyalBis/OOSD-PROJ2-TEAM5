using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

/**********************************************************************
Title:                ProductSupplierTable.cs  
 Project:          Travel Experts Desktop App
Authors:         Royal Bissell, Kevin Liao, Annie Ali, Lee Harrold
Class:               OOSD Fall 2015 
Date:               2016/02/07
Description:  Data Access Class for Quering the Products_Suppliers Table in the Travel Experts Database
**********************************************************************/

namespace TravelExpertsDB
{
    /// <summary>
    /// TravelExperts ProductSupplier Table Access Class
    /// </summary>
    public static class ProductSupplierTable
    {
        #region Query Strings
        //Statement for SearchProductsSupplier()
        private static string SearchAll = "SELECT ps.ProductSupplierId, p.ProductId, ProdName, s.SupplierId, SupName " +
                                                                         "FROM Products_Suppliers ps, Products p, Suppliers s " +
                                                                         "WHERE ps.SupplierId = s.SupplierId " +
                                                                         "AND ps.ProductId = p.ProductId " +
                                                                         "AND (ps.ProductSupplierId LIKE @searchIndex + '%' " +
                                                                         "OR p.ProductId LIKE @searchIndex +  '%' " +
                                                                         "OR ProdName LIKE  '%' + @searchIndex + '%' " +
                                                                         "OR  s.SupplierId LIKE @searchIndex +  '%' " +
                                                                         "OR SupName LIKE  '%' + @searchIndex + '%') " +
                                                                         "ORDER BY ProductSupplierId";

        //Statement to get a ProductSupplier with the specified Id
        private static string GetStmt = "SELECT ps.ProductSupplierId, p.ProductId, ProdName, s.SupplierId, SupName " +
                                                                       "FROM Products_Suppliers ps, Products p, Suppliers s " +
                                                                       "WHERE ps.SupplierId = s.SupplierId " +
                                                                       "AND ps.ProductId = p.ProductId " +
                                                                       "AND ps.ProductSupplierId = @ProductSupplierId";

        //Statement to get all ProductSuppliers
        private static string GetAllStmt = "SELECT ps.ProductSupplierId, p.ProductId, ProdName, s.SupplierId, SupName " +
                                                                            "FROM Products_Suppliers ps, Products p, Suppliers s " +
                                                                            "WHERE ps.SupplierId = s.SupplierId " +
                                                                            "AND ps.ProductId = p.ProductId " +
                                                                            "ORDER BY ProductID";

        //Statement to get all ProductSuppliers that are part of a package
        private static string GetAllofPkgStmt = "SELECT pps.ProductSupplierId, p.ProductId, ProdName, s.SupplierId, SupName " +
                                                                                        "FROM Packages_Products_Suppliers pps, Products_Suppliers ps, Products p, Suppliers s " +
                                                                                        "WHERE pps.ProductSupplierId = ps.ProductSupplierId " +
                                                                                        "AND ps.SupplierId = s.SupplierId " +
                                                                                        "AND ps.ProductId = p.ProductId " +
                                                                                        "AND PackageId = @PackageId";

        //Statement for AddPkgProdSup()
        private const string InsertStmt = "INSERT INTO Products_Suppliers " +
                                                                            "(ProductId, SupplierId) " +
                                                                            "VALUES(@ProductId, @SupplierId)";

        //Statement for UpdateSupplier()
        private const string UpdateStmt = "UPDATE Products_Suppliers " +
                                                                                "SET ProductId = @NewProductId, " +
                                                                                "SupplierId = @NewSupplierId " +
                                                                                "WHERE ProductSupplierId = @ProductSupplierId " +
                                                                                "AND ProductId = @OldProductId " +
                                                                                "AND SupplierId = @OldSupplierId";
        #endregion

        #region Database Queries
        /// <summary>
        /// Get a Product Supplier with the specified ProductSupplierId
        /// </summary>
        /// <param name="productSupplierId">int ProductSupplierId</param>
        /// <returns>ProductSupplier</returns>
        public static ProductSupplier GetProductSupplier(int productSupplierId)
        {
            //get the command
            SqlCommand command = TravelExpertsCommon.GetCommand(GetStmt);
            //parameterize the command
            command.Parameters.AddWithValue("@ProductSupplierId", productSupplierId);

            //Using will auto close the connection once the block is ended
            using (command.Connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    command.Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        //build the ProductSupplier from the result
                        ProductSupplier prodSup = CreateProdSup(reader);
                        return prodSup;
                    }
                    //no results
                    return null;
                }
                catch (Exception ex) //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }

        /// <summary>
        /// Get all ProductSuppliers
        /// </summary>
        /// <returns>List of Product Suppliers</returns>
        public static List<ProductSupplier> GetAllProductSuppliers()
        {
            //List Variable for Product Suppliers
            List<ProductSupplier> prodSups = new List<ProductSupplier>();
            //Get the Command
            SqlCommand command = TravelExpertsCommon.GetCommand(GetAllStmt);

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
                        //build each product Supplier 
                        prodSups.Add(CreateProdSup(reader));
                    }
                    //return the list
                    return prodSups;
                }
                catch (Exception ex) //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }

        /// <summary>
        /// Get every ProductSupplier has an Id in the array of productsupplierIds 
        /// </summary>
        /// <param name="prodsupIds">int Array, ProductSupplierIds </param>
        /// <returns>List of ProductSuppliers</returns>
        public static List<ProductSupplier> GetRangeProductSuppliers(int[] prodsupIds)
        {
            //List Var for Product Suppliers
            List<ProductSupplier> prodSups = new List<ProductSupplier>();
            //For some reason this string statement needs to be here, because the variable has trouble being parameterized...
            string GetAllFromIdsStmt = "SELECT ps.ProductSupplierId, p.ProductId, ProdName, s.SupplierId, SupName " +
                                       "FROM Products_Suppliers ps, Products p, Suppliers s " +
                                       "WHERE ps.SupplierId = s.SupplierId " +
                                       "AND ps.ProductId = p.ProductId " +
                                       "AND ProductSupplierId IN (" + string.Join(", ", prodsupIds) + ")";
            //get the command
            SqlCommand command = TravelExpertsCommon.GetCommand(GetAllFromIdsStmt);

            //command.Parameters.AddWithValue("@ProductSupplierIds", string.Join(", ", prodsupIds));

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
                        //build each Product Supplier
                        prodSups.Add(CreateProdSup(reader));
                    }
                    //return the product suppliers, empty list if it didn't work
                    return prodSups;
                }
                catch (Exception ex) //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }

        /// <summary>
        /// Adds all ProductSuppliers to the passed in Package
        /// </summary>
        /// <param name="package">Package</param>
        public static void AssignPkgProductSuppliers(Package package)
        {
            //get the command
            SqlCommand command = TravelExpertsCommon.GetCommand(GetAllofPkgStmt);
            //parameterize the command
            command.Parameters.AddWithValue("@PackageId", package.PackageId);

            //Using will auto close the connection once the block is ended
            using (command.Connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    command.Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    //Empty the List of Current Product Suppliers so we don't duplicate te list
                    package.PkgProductSuppliers?.Clear();   //null check just makes sure the is a list of ProductSuppliers
                    while (reader.Read())
                    {
                        //Add each Product Supplier to the  Package
                        package.PkgProductSuppliers?.Add(CreateProdSup(reader));
                    }
                }
                catch (Exception ex) //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }

        /// <summary>
        /// Search All Product Suppliers for the specified Search String
        /// </summary>
        /// <param name="searchStr">string</param>
        /// <returns>List of Product Suppliers</returns>
        public static List<ProductSupplier> SearchAllProdSups(string searchStr)
        {
            //We need a productsuppliers list to return; either a list of productsuppliers or an empty list
            List<ProductSupplier> prodSups = new List<ProductSupplier>();
            //get the connection and make a new select statement
            SqlCommand command = TravelExpertsCommon.GetCommand(SearchAll);
            //Parameterize the command
            command.Parameters.AddWithValue("@searchIndex", searchStr);

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
                        //Build each Product Supplier and Add it to the List
                        prodSups.Add(CreateProdSup(reader));
                    }
                    //return the list of ProductSuppliers, Null if it didn't work
                    return prodSups;
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }

        /// <summary>
        /// Add a new Product Supplier
        /// </summary>
        /// <param name="prodsupp">ProductSupplier</param>
        /// <returns>return true if insert is successful</returns>
        public static bool AddProdSupp(ProductSupplier prodsupp)
        {
            //get the connection and make a new select statement
            SqlCommand command = TravelExpertsCommon.GetCommand(InsertStmt);
            //add the Product Parameters to the SQL Insert Command
            command.Parameters.AddWithValue("@ProductId", prodsupp.MyProduct.ProductId);
            command.Parameters.AddWithValue("@SupplierId", prodsupp.MySupplier.SupplierId);

            //just perform the query and return the result
            return TravelExpertsCommon.PerformNonQuery(command);
        }

        /// <summary>
        /// Update a Exisitng ProductSupplier
        /// </summary>
        /// <param name="newProdSupp">ProductSupplier, New</param>
        /// <param name="oldProdSupp">ProductSupplier, Existing</param>
        /// <returns>true if update was successful</returns>
        public static bool UpdateProdSupp(ProductSupplier newProdSupp, ProductSupplier oldProdSupp)
        {
            //get the connection and make a new select statement
            SqlCommand command = TravelExpertsCommon.GetCommand(UpdateStmt);
            //add the Product Parameters to the SQL update Command
            command.Parameters.AddWithValue("@ProductSupplierId", oldProdSupp.ProductSupplierId);
            command.Parameters.AddWithValue("@NewProductId", newProdSupp.MyProduct.ProductId);
            command.Parameters.AddWithValue("@NewSupplierId", newProdSupp.MySupplier.SupplierId);
            command.Parameters.AddWithValue("@OldProductId", oldProdSupp.MyProduct.ProductId);
            command.Parameters.AddWithValue("@OldSupplierId", oldProdSupp.MySupplier.SupplierId);

            //just perform the query and return the result
            return TravelExpertsCommon.PerformNonQuery(command);
        }
        #endregion

        /// <summary>
        /// Create ProductSuppliers from a Database Query
        /// </summary>
        /// <param name="reader">SqlDataReader</param>
        /// <returns>ProductSupplier</returns>
        internal static ProductSupplier CreateProdSup(SqlDataReader reader)
        {
            ProductSupplier prodSup = new ProductSupplier();
            prodSup.ProductSupplierId = (int)reader["ProductSupplierId"];
            //Add the new product supplier to the package
            prodSup.MyProduct = ProductsTable.CreateProduct(reader);
            prodSup.MySupplier = SuppliersTable.CreateSupplier(reader);

            return prodSup;
        }
    }
}
