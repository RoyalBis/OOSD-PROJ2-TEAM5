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
                                          "FROM ProdName";

        //Statement for GetSupplier()
        private const string GetStmt = "SELECT SupplierId, SupName " +
                                       "FROM Supplier " +
                                       "WHERE SupplierId = @SupplierId";

        //Statement for GetSuppliersofProduct()
        private const string GetAllOfProductStmt = "SELECT SupplierID, SupName " +
                                                   "FROM Supplier " +
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

        public static List<Product> GetAllProducts()
        {
            //We need a suppliers list to return; either a list of suppliers or an empty list
            List<Product> products = new List<Product>();
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
            SqlConnection connection = new SqlConnection();
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
            //Enter Code Here

            return products;
        }

        //Static Method to add a new Product
        public static bool AddProduct(Product prod)
        {

            return true;
        }

        //Static Method to update an existing Product
        public static bool UpdateProduct(Product newProd, Product oldProd)
        {
            return true;
        }
    }
}
