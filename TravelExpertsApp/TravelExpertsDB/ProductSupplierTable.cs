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
                        prodSup.ProductSupplierId = (int)reader["ProductSupplierId"];
                        prodSup.ProductId = (int)reader["ProductId"];
                        prodSup.SupplierId = (int)reader["SupplierId"];
                        prodSup.ProdName = reader["ProdName"].ToString();
                        prodSup.SupName = reader["SupName"].ToString();
                        //Add the new product supplier to the package
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
