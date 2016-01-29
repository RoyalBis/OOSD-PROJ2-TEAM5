﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace TravelExpertsDB
{
    public static class ProductSupplierTable
    {
        #region Query Strings
        //Statement for SearchProducts()
        private static string SearchAllLikeProdSupID = "SELECT ps.ProductSupplierId, p.ProductId, ProdName, s.SupplierId, SupName " +
                                                       "FROM Products_Suppliers ps, Products p, Suppliers s " +
                                                       "WHERE ps.SupplierId = s.SupplierId " +
                                                       "AND ps.ProductId = p.ProductId " +
                                                       "AND ps.ProductSupplierId LIKE @searchIndex + '%' " +
                                                       "ORDER BY ProductID";

        private static string GetStmt = "SELECT ps.ProductSupplierId, p.ProductId, ProdName, s.SupplierId, SupName " +
                                        "FROM Products_Suppliers ps, Products p, Suppliers s " +
                                        "WHERE ps.SupplierId = s.SupplierId " +
                                        "AND ps.ProductId = p.ProductId " +
                                        "AND ps.ProductSupplierId = @ProductSupplierId";

        private static string GetAllStmt = "SELECT ps.ProductSupplierId, p.ProductId, ProdName, s.SupplierId, SupName " +
                                           "FROM Products_Suppliers ps, Products p, Suppliers s " +
                                           "WHERE ps.SupplierId = s.SupplierId " +
                                           "AND ps.ProductId = p.ProductId " +
                                           "ORDER BY ProductID";

        private static string GetAllofPkgStmt = "SELECT pps.ProductSupplierId, p.ProductId, ProdName, s.SupplierId, SupName " +
                                                "FROM Packages_Products_Suppliers pps, Products_Suppliers ps, Products p, Suppliers s " +
                                                "WHERE pps.ProductSupplierId = ps.ProductSupplierId " +
                                                "AND ps.SupplierId = s.SupplierId " +
                                                "AND ps.ProductId = p.ProductId " +
                                                "AND PackageId = @PackageId";
        #endregion

        #region Database Queries
        public static ProductSupplier GetProductSupplier(int productSupplierId)
        {
            SqlCommand command = TravelExpertsCommon.GetCommand(GetStmt);
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
                        ProductSupplier prodSup = CreateProdSup(reader);
                        return prodSup;
                    }
                    return null;
                }
                catch (Exception ex) //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }

        public static List<ProductSupplier> GetAllProductSuppliers()
        {
            List<ProductSupplier> prodSups = new List<ProductSupplier>();
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
                        prodSups.Add(CreateProdSup(reader));
                    }
                    return prodSups;
                }
                catch (Exception ex) //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }

        public static List<ProductSupplier> GetRangeProductSuppliers(int[] prodsupIds)
        {
            List<ProductSupplier> prodSups = new List<ProductSupplier>();
            string GetAllFromIdsStmt = "SELECT ps.ProductSupplierId, p.ProductId, ProdName, s.SupplierId, SupName " +
                                       "FROM Products_Suppliers ps, Products p, Suppliers s " +
                                       "WHERE ps.SupplierId = s.SupplierId " +
                                       "AND ps.ProductId = p.ProductId " +
                                       "AND ProductSupplierId IN (" + string.Join(", ", prodsupIds) + ")";
            SqlCommand command = TravelExpertsCommon.GetCommand(GetAllFromIdsStmt);

            command.Parameters.AddWithValue("@ProductSupplierIds", string.Join(", ", prodsupIds));

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
                        prodSups.Add(CreateProdSup(reader));
                    }
                    return prodSups;
                }
                catch (Exception ex) //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }

        public static void AssignPkgProductSuppliers(Package package)
        {
            SqlCommand command = TravelExpertsCommon.GetCommand(GetAllofPkgStmt);
            command.Parameters.AddWithValue("@PackageId", package.PackageId);

            //Using will auto close the connection once the block is ended
            using (command.Connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    command.Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    //Empty the List of Current Product Suppliers
                    package.PkgProductSuppliers?.Clear();
                    while (reader.Read())
                    {
                        package.PkgProductSuppliers?.Add(CreateProdSup(reader));
                    }
                    reader.Close();
                }
                catch (Exception ex) //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }

        //NO LONGER NEEDED USING A LINQ STATEMENT AGAIN
        //private static string searchString;
        //public static List<ProductSupplier> SearchAllProdSups(string searchParam, string searchIndex)
        //{
        //    switch (searchParam)
        //    {
        //        case "ProductSupplier":
        //            searchString = SearchAllLikeProdSupID;
        //            break;
        //        case "Product":
        //            searchString = "AND ps.ProductSupplierId LIKE @searchIndex + '%' ";
        //            break;
        //        case "Supplier":
        //            searchString = "AND ps.ProductSupplierId LIKE @searchIndex + '%' ";
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException(searchParam.ToString());
        //    }
        //    List<ProductSupplier> prodSups = new List<ProductSupplier>();
        //    //We need a suppliers list to return; either a list of suppliers or an empty list
        //    List<Product> products = new List<Product>();
        //    //get the connection and make a new select statement
        //    SqlConnection connection = TravelExpertsCommon.GetConnection();
        //    SqlCommand selectCommand = new SqlCommand(searchString, connection);
        //    selectCommand.Parameters.AddWithValue("@searchIndex", searchIndex);

        //    //Using will auto close the connection once the block is ended
        //    using (connection)
        //    {
        //        //try in case of errors and re-throw them to the UI
        //        try
        //        {
        //            connection.Open();

        //            SqlDataReader reader = selectCommand.ExecuteReader();
        //            while (reader.Read())
        //            {
        //                ProductSupplier prodSup = new ProductSupplier();
        //                Product product = new Product();
        //                Supplier supplier = new Supplier();
        //                prodSup.ProductSupplierId = (int)reader["ProductSupplierId"];
        //                product.ProductId = (int)reader["ProductId"];
        //                product.ProdName = reader["ProdName"].ToString();
        //                supplier.SupplierId = (int)reader["SupplierId"];
        //                supplier.SupName = reader["SupName"].ToString();
        //                //Add the new product supplier to the package
        //                prodSup.MyProduct = product;
        //                prodSup.MySupplier = supplier;
        //                prodSups.Add(prodSup);
        //            }
        //        }
        //        catch (Exception ex)    //catch all exceptions and re-throw them
        //        {
        //            products = null;   //an error occurred so lets not continue
        //            throw ex;
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //    }   //end of the using statement
        //    return prodSups;
        //}
        #endregion

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
