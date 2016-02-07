using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

/**********************************************************************
Title:                ProductsTable.cs  
 Project:          Travel Experts Desktop App
Authors:         Royal Bissell, Kevin Liao, Annie Ali, Lee Harrold
Class:               OOSD Fall 2015 
Date:               2016/02/07
Description:  Data Access Class for Quering the Products Table in the Travel Experts Database
**********************************************************************/

namespace TravelExpertsDB
{
    /// <summary>
    /// TravelExperts Products Table Access Class
    /// </summary>
    public class ProductsTable
    {
        #region Query Strings
        //SQL STATEMENTS\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //Statement for GetAllProducts()
        private const string GetAllStmt = "SELECT ProductId, ProdName " +
                                                                              "FROM Products";

        //Statement for GetProduct()
        private const string GetStmt = "SELECT ProductId, ProdName " +
                                                                        "FROM Products " +
                                                                        "WHERE ProductId = @ProductId";

        //Statement for AddProduct()
        private const string InsertStmt = "INSERT INTO Products " +
                                                                            "(ProdName) " +
                                                                            "VALUES(@ProdName)";

        //Statement for UpdateProduct()
        private const string UpdateStmt = "UPDATE Products " +
                                                                                "SET ProdName = @NewProdName " +
                                                                                "WHERE ProductId = @OldProductId " +
                                                                                "AND ProdName = @OldProdName";
        //Statement for SearchProducts()
        private const string SearchAll = "SELECT ProductId, ProdName " +
                                                                          " FROM Products " +
                                                                          " WHERE ProdName LIKE  '%' + @searchIndex + '%' OR ProductId LIKE '%' + @searchIndex + '%'";
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        #endregion  

        #region Database Queries
        /// <summary>
        /// Get all the Products from the database
        /// </summary>
        /// <returns>List of Products</returns>
        public static List<Product> GetAllProducts()
        {
            //We need a suppliers list to return; either a list of suppliers or an empty list
            List<Product> products = new List<Product>();
            //get the connection and make a new select statement
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
                        //build a new Product Object for each returned product
                        //and add the supplier to the list
                        products.Add(CreateProduct(reader));
                    }
                    return products;
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }

        /// <summary>
        /// Get one productfrom the database based on a product id
        /// </summary>
        /// <param name="productId">int ProductId</param>
        /// <returns>Product</returns>
        public static Product GetProduct(int productId)
        {
            //get the connection and make a new select statement
            SqlCommand command = TravelExpertsCommon.GetCommand(GetStmt);
            //add the supplierId Parameter to the SQL Command
            command.Parameters.AddWithValue("@ProductId", productId);

            //Using will auto close the connection once the block is ended
            using (command.Connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    command.Connection.Open();

                    //will only be one ever: productId is the unique key
                    SqlDataReader reader = command.ExecuteReader(CommandBehavior.SingleRow);
                    if (reader.Read())
                    {
                        //build a new Product Object
                        return CreateProduct(reader);
                    }
                    return null;
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }

       /// <summary>
       /// Insert a new Product into the database
       /// </summary>
       /// <param name="prod">Product</param>
       /// <returns>true if insert was successful</returns>
        public static bool AddProduct(Product prod)
        {
            //get the connection and make a new select statement
            SqlCommand command = TravelExpertsCommon.GetCommand(InsertStmt);
            //add the Product Parameters to the SQL Insert Command
            //command.Parameters.AddWithValue("@ProductId", prod.ProductId);
            command.Parameters.AddWithValue("@ProdName", prod.ProdName);

            //just perform the query and return the result
            return TravelExpertsCommon.PerformNonQuery(command);
        }

        /// <summary>
        /// Update a Product
        /// </summary>
        /// <param name="newProd">Product, New</param>
        /// <param name="oldProd">Product, Exisiting</param>
        /// <returns>returns true if update was successful</returns>
        public static bool UpdateProduct(Product newProd, Product oldProd)
        {
            //get the connection and make a new select statement
            SqlCommand command = TravelExpertsCommon.GetCommand(UpdateStmt);
            //add the Product Parameters to the SQL update Command
            command.Parameters.AddWithValue("@NewProdName", newProd.ProdName);
            command.Parameters.AddWithValue("@OldProductId", oldProd.ProductId);
            command.Parameters.AddWithValue("@OldProdName", oldProd.ProdName);

            //just perform the query and return the result
            return TravelExpertsCommon.PerformNonQuery(command);
        }

        /// <summary>
        /// search all products based on a search string
        /// </summary>
        /// <param name="searchIndex">string</param>
        /// <returns>List of Products</returns>
        public static List<Product> SearchAllProducts(string searchIndex)
        {
            //We need a suppliers list to return; either a list of suppliers or an empty list
            List<Product> products = new List<Product>();
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
                        //build a new Product Object for each returned product
                        //add the products to the list
                        products.Add(CreateProduct(reader));
                    }
                    return products;
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }
        #endregion

        /// <summary>
        /// Common method to build Products from a database query
        /// </summary>
        /// <param name="reader">SqlDataReader</param>
        /// <returns>Product</returns>
        internal static Product CreateProduct(SqlDataReader reader)
        {
            Product product = new Product();
            product.ProductId = (int)reader["ProductId"];
            product.ProdName = reader["ProdName"].ToString();

            return product;
        }
    }
}
