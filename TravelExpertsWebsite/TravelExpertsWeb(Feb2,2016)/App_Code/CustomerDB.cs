using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerDB
/// </summary>

public static class CustomerDB
{
    public static int AddCustomer(Customer customer)
    {
        SqlConnection connection = TravelExpertsDB.GetConnection();
        string insertStatement =
            "INSERT Customers " +
            "(CustFirstName, CustLastName, CustAddress, CustCity, CustProv, CustPostal, CustCountry, CustHomePhone, CustBusPhone, CustEmail, Username, Password) " +
            "VALUES (@CustFirstName, @CustLastName, @CustAddress, @CustCity, @CustProv, @CustPostal, @CustCountry, @CustHomePhone, @CustBusPhone, @CustEmail, @Username, @Password)";
        SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
        insertCommand.Parameters.AddWithValue("@CustFirstName", customer.CustFirstName);
        insertCommand.Parameters.AddWithValue("@CustLastName", customer.CustLastName);
        insertCommand.Parameters.AddWithValue("@CustAddress", customer.CustAddress);
        insertCommand.Parameters.AddWithValue("@CustCity", customer.CustCity);
        insertCommand.Parameters.AddWithValue("@CustProv", customer.CustProv);
        insertCommand.Parameters.AddWithValue("@CustPostal", customer.CustPostal);
        insertCommand.Parameters.AddWithValue("@CustCountry", customer.CustCountry);
        insertCommand.Parameters.AddWithValue("@CustHomePhone", customer.CustHomePhone);
        insertCommand.Parameters.AddWithValue("@CustBusPhone", customer.CustBusPhone);
        insertCommand.Parameters.AddWithValue("@CustEmail", customer.CustEmail);
        //insertCommand.Parameters.AddWithValue("@AgentId", customer.AgentId);
        insertCommand.Parameters.AddWithValue("@Username", customer.Username);
        insertCommand.Parameters.AddWithValue("@Password", customer.Password);
        try
        {
            connection.Open();
            insertCommand.ExecuteNonQuery();
            string selectStatement =
                "SELECT IDENT_CURRENT('Customers') FROM Customers";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            int customerID = Convert.ToInt32(selectCommand.ExecuteScalar());
            return customerID;
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        finally
        {
            connection.Close();
        }
    }

    public static Customer UserLogin(Customer customer)
    {
        SqlConnection connection = TravelExpertsDB.GetConnection();
        string selectStatement = "SELECT CustFirstName, CustomerId " +
                                 "FROM Customers " +
                                 "WHERE Username=@Username " +
                                 "  AND Password=@Password";
        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
        selectCommand.Parameters.AddWithValue("@Username", customer.Username);
        selectCommand.Parameters.AddWithValue("@Password", customer.Password);

        try
        {
            connection.Open();
            SqlDataReader custReader = selectCommand.ExecuteReader();
            if (custReader.Read())
            {
                Customer cust = new Customer();
                cust.CustFirstName= custReader["CustFirstName"].ToString();
                cust.CustomerId = (int)custReader["CustomerId"];
                return cust;                
            }
            else
            {
                return null;
            }
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        finally
        {
            connection.Close();
        }
    }

    public static List<BookingDetail> UserBooking(int custID)
    {
        SqlConnection connection = TravelExpertsDB.GetConnection();
        string selectStatement = "SELECT b.BookingId, TripStart, TripEnd, Description, Destination, BasePrice, ClassId " +
                                 "FROM Bookings as b, BookingDetails as bd " +
                                 "WHERE b.BookingId=bd.BookingId " +
                                 "  AND CustomerId=@CustomerId";
        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
        selectCommand.Parameters.AddWithValue("@CustomerId", custID);

        try
        {
            connection.Open();
            SqlDataReader bdReader = selectCommand.ExecuteReader();
            List<BookingDetail> mylist = new List<BookingDetail>();
            while (bdReader.Read())
            {
                BookingDetail bd = new BookingDetail();
                bd.BookingId = (int)bdReader["BookingId"];
                bd.TripStart = (DateTime)bdReader["TripStart"];
                bd.TripEnd = (DateTime)bdReader["TripEnd"];
                bd.Description = bdReader["Description"].ToString();
                bd.Destination = bdReader["Destination"].ToString();
                bd.BasePrice = (decimal)bdReader["BasePrice"];
                bd.ClassId = bdReader["ClassId"].ToString();
                mylist.Add(bd);
            }
            return mylist;
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        finally
        {
            connection.Close();
        }
    }
}