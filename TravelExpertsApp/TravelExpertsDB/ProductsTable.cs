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
                                          "(ProdName) " +
                                          "VALUES(@ProdName)";

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

        #region Database Queries
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

        //Static Method to return a list of all the Product offered by a supplier
        public static List<Product> GetProductsfromSupplier(int supplierId)
        {
            List<Product> products = new List<Product>();

            //get the connection and make a new select statement
            SqlCommand command = TravelExpertsCommon.GetCommand(GetStmt);
            command.Parameters.AddWithValue("@SupplierId", "supplierId");

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

        //Static Method to add a new Product
        public static bool AddProduct(Product prod)
        {
            //get the connection and make a new select statement
            SqlCommand command = TravelExpertsCommon.GetCommand(InsertStmt);
            //add the Product Parameters to the SQL Insert Command
            //command.Parameters.AddWithValue("@ProductId", prod.ProductId);
            command.Parameters.AddWithValue("@ProdName", prod.ProdName);

            return TravelExpertsCommon.PerformNonQuery(command);
        }

        //Static Method to update an existing Product
        public static bool UpdateProduct(Product newProd, Product oldProd)
        {
            //get the connection and make a new select statement
            SqlCommand command = TravelExpertsCommon.GetCommand(UpdateStmt);
            //add the Product Parameters to the SQL update Command
            command.Parameters.AddWithValue("@NewProdName", newProd.ProdName);
            command.Parameters.AddWithValue("@OldProductId", oldProd.ProductId);
            command.Parameters.AddWithValue("@OldProdName", oldProd.ProdName);

            return TravelExpertsCommon.PerformNonQuery(command);
        }

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

        internal static Product CreateProduct(SqlDataReader reader)
        {
            Product product = new Product();
            product.ProductId = (int)reader["ProductId"];
            product.ProdName = reader["ProdName"].ToString();

            return product;
        }
    }
}
