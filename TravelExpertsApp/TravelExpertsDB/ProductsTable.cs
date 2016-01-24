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
    public class ProductsTable
    {
        //SQL STATEMENTS\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //Statement for GetAllSuppliers()
        private const string GetAllStmt = "SELECT ProductId, ProdName " +
                                          "FROM Products";

        //Statement for GetSupplier()
        private const string GetStmt = "SELECT ProductId, ProdName " +
                                       "FROM Products " +
                                       "WHERE ProductId = @ProductId";

        //Statement for GetSuppliersofProduct()
        private const string GetAllOfSupplierStmt = "SELECT ProductID, ProdName " +
                                                    "FROM Products " +
                                                    "INNER JOIN Products_Suppliers " +
                                                    "WHERE SupplierId = @SupplierId";

        //Statement for AddSupplier()
        private const string InsertStmt = "INSERT INTO Products " +
                                          "(ProductId, ProdName) " +
                                          "VALUES(@ProductId, @ProdName)";

        //Statement for UpdateSupplier()
        private const string UpdateStmt = "UPDATE Products " +
                                          "SET ProdName = @NewProdName " +
                                          "WHERE ProductId = @OldProductId " +
                                          "AND ProdName = @OldProdName";
        //Statement for SearchProducts()
        private const string SearchAll = "SELECT ProductId, ProdName " +
                                         " FROM Products " +
                                         " WHERE ProdName LIKE  '%' + @searchIndex + '%' OR ProductId LIKE '%' + @searchIndex + '%'";
        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        public static List<Product> GetAllProducts()
        {
            //We need a suppliers list to return; either a list of suppliers or an empty list
            List<Product> products = new List<Product>();
            //get the connection and make a new select statement
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            SqlCommand selectCommand = new SqlCommand(GetAllStmt, connection);

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
                        //build a new Product Object for each returned product
                        Product product = new Product
                        {
                            ProductId = (int)reader["ProductId"],
                            ProdName = reader["ProdName"].ToString()
                        };
                        //add the supplier to the list
                        products.Add(product);
                    }
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    products = null;   //an error occurred so lets not continue
                    throw ex;
                }
            }   //end of the using statement
            return products;
        }

        public static Product GetProduct(string productId)
        {
            //We need a supplier to return or null
            Product product = null;
            //get the connection and make a new select statement
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            SqlCommand selectCommand = new SqlCommand(GetStmt, connection);
            //add the supplierId Parameter to the SQL Command
            selectCommand.Parameters.AddWithValue("@ProductId", productId);

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
                        product = new Product
                        {
                            ProductId = (int)reader["ProductId"],
                            ProdName = reader["ProdName"].ToString()
                        };
                    }
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement

            return product;
        }

        //Static Method to return a list of all the Product offered by a supplier
        public static List<Product> GetProductsfromSupplier(int supplierId)
        {
            List<Product> products = new List<Product>();

            //get the connection and make a new select statement
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            SqlCommand selectCommand = new SqlCommand(GetAllOfSupplierStmt, connection);
            selectCommand.Parameters.AddWithValue("@SupplierId", "supplierId");

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
                        //build a new Product Object for each returned Product
                        Product product = new Product
                        {
                            ProductId = (int)reader["ProductId"],
                            ProdName = reader["ProdName"].ToString()
                        };
                        //add the supplier to the list
                        products.Add(product);
                    }
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    products = null;   //an error occurred so lets not continue
                    throw ex;
                }
            }   //end of the using statement
            return products;
        }

        //Static Method to add a new Product
        public static bool AddProduct(Product prod)
        {
            //get the connection and make a new select statement
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            SqlCommand insertCommand = new SqlCommand(InsertStmt, connection);
            //add the Product Parameters to the SQL Insert Command
            insertCommand.Parameters.AddWithValue("@ProductId", prod.ProductId);
            insertCommand.Parameters.AddWithValue("@ProdName", prod.ProdName);

            //Using will auto close the connection once the block is ended
            using (connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    connection.Open();

                    int nr = insertCommand.ExecuteNonQuery();   //nr is the number of rows that are affected
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

        //Static Method to update an existing Product
        public static bool UpdateProduct(Product newProd, Product oldProd)
        {
            //get the connection and make a new select statement
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            SqlCommand updateCommand = new SqlCommand(UpdateStmt, connection);
            //add the Product Parameters to the SQL update Command
            updateCommand.Parameters.AddWithValue("@NewProdName", newProd.ProdName);
            updateCommand.Parameters.AddWithValue("@OldProductId", oldProd.ProductId);
            updateCommand.Parameters.AddWithValue("@OldProdName", oldProd.ProdName);

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

        public static List<Product> SearchAllProducts(string searchIndex)
        {
            //We need a suppliers list to return; either a list of suppliers or an empty list
            List<Product> products = new List<Product>();
            //get the connection and make a new select statement
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            SqlCommand selectCommand = new SqlCommand(SearchAll, connection);
            selectCommand.Parameters.AddWithValue("@searchIndex", searchIndex);

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
                        //build a new Product Object for each returned product
                        Product product = new Product
                        {
                            ProductId = (int)reader["ProductId"],
                            ProdName = reader["ProdName"].ToString()
                        };
                        //add the products to the list
                        products.Add(product);
                    }
                }
                catch (Exception ex)    //catch all exceptions and re-throw them
                {
                    products = null;   //an error occurred so lets not continue
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }   //end of the using statement
            return products;
        }
    }
}
