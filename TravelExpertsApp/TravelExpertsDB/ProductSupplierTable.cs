using System;
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
        public static List<ProductSupplier> GetAllProductSuppliers()
        {
            List<ProductSupplier> prodSups = new List<ProductSupplier>();
            SqlConnection connection = TravelExpertsCommon.GetConnection();
            string selectString = "SELECT ps.ProductSupplierId, p.ProductId, ProdName, s.SupplierId, SupName " +
                                  "FROM Products_Suppliers ps, Products p, Suppliers s " +
                                  "WHERE ps.SupplierId = s.SupplierId " +
                                  "AND ps.ProductId = p.ProductId";
            SqlCommand selectCommand = new SqlCommand(selectString, connection);

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
                        ProductSupplier prodSup = new ProductSupplier();
                        Product product = new Product();
                        Supplier supplier = new Supplier();
                        prodSup.ProductSupplierId = (int)reader["ProductSupplierId"];
                        product.ProductId = (int)reader["ProductId"];
                        product.ProdName = reader["ProdName"].ToString();
                        supplier.SupplierId = (int)reader["SupplierId"];
                        supplier.SupName = reader["SupName"].ToString();
                        //Add the new product supplier to the package
                        prodSup.MyProduct = product;
                        prodSup.MySupplier = supplier;
                        prodSups.Add(prodSup);
                    }
                    return prodSups;
                }
                catch (Exception ex) //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }

        public static void GetProductSuppliers(Package package)
        {

            SqlConnection connection = TravelExpertsCommon.GetConnection();
            string selectString = "SELECT pps.ProductSupplierId, p.ProductId, ProdName, s.SupplierId, SupName " +
                                  "FROM Packages_Products_Suppliers pps, Products_Suppliers ps, Products p, Suppliers s " +
                                  "WHERE pps.ProductSupplierId = ps.ProductSupplierId " +
                                  "AND ps.SupplierId = s.SupplierId " +
                                  "AND ps.ProductId = p.ProductId " +
                                  "AND PackageId = @PackageId";
            SqlCommand selectCommand = new SqlCommand(selectString, connection);
            selectCommand.Parameters.AddWithValue("@PackageId", package.PackageId);

            //Using will auto close the connection once the block is ended
            using (connection)
            {
                //try in case of errors and re-throw them to the UI
                try
                {
                    connection.Open();
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    //Empty the List of Current Product Suppliers
                    package.PkgProductSuppliers?.Clear();
                    while (reader.Read())
                    {
                        ProductSupplier prodSup = new ProductSupplier();
                        Product product = new Product();
                        Supplier supplier = new Supplier();
                        prodSup.ProductSupplierId = (int)reader["ProductSupplierId"];
                        product.ProductId = (int)reader["ProductId"];
                        product.ProdName = reader["ProdName"].ToString();
                        supplier.SupplierId = (int)reader["SupplierId"];
                        supplier.SupName = reader["SupName"].ToString();
                        //Add the new product supplier to the package
                        prodSup.MyProduct = product;
                        prodSup.MySupplier = supplier;
                        package.PkgProductSuppliers.Add(prodSup);
                    }
                    reader.Close();
                }
                catch (Exception ex) //catch all exceptions and re-throw them
                {
                    throw ex;
                }
            }   //end of the using statement
        }
    }
}
