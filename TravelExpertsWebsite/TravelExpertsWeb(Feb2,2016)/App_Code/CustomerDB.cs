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
[DataObject]
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
                DateTime TripStart = (DateTime)bdReader["TripStart"];
                bd.TripStart = TripStart.ToString("yyyy-MM-dd");
                DateTime TripEnd = (DateTime)bdReader["TripEnd"];
                bd.TripEnd = TripEnd.ToString("yyyy-MM-dd");
                bd.Description = bdReader["Description"].ToString();
                bd.Destination = bdReader["Destination"].ToString();
                decimal BasePrice = (decimal)bdReader["BasePrice"];
                bd.BasePrice = BasePrice.ToString("C");
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

    [DataObjectMethod(DataObjectMethodType.Select)]
    public static Customer SelectThisCustomer(int custID)
    {
        SqlConnection connection = TravelExpertsDB.GetConnection();
        string selectStatement = "SELECT CustomerId, CustFirstName, CustLastName, CustAddress, CustCity, CustProv, CustPostal, CustCountry, CustHomePhone, CustBusPhone, CustEmail, AgentId, Username, Password " +
                                 "FROM Customers " +
                                 "WHERE CustomerId=@CustomerId";
        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
        selectCommand.Parameters.AddWithValue("@CustomerId", custID);

        try
        {
            connection.Open();
            SqlDataReader custReader = selectCommand.ExecuteReader();
            if (custReader.Read())
            {
                Customer cust = new Customer();
                cust.CustomerId = (int)custReader["CustomerId"];
                cust.CustFirstName = custReader["CustFirstName"].ToString();
                cust.CustLastName = custReader["CustLastName"].ToString();
                cust.CustAddress = custReader["CustAddress"].ToString();
                cust.CustCity = custReader["CustCity"].ToString();
                cust.CustProv = custReader["CustProv"].ToString();
                cust.CustPostal = custReader["CustPostal"].ToString();
                cust.CustCountry = custReader["CustCountry"].ToString();
                cust.CustHomePhone = custReader["CustHomePhone"].ToString();
                cust.CustBusPhone = custReader["CustBusPhone"].ToString();
                cust.CustEmail = custReader["CustEmail"].ToString();
                cust.AgentId = custReader["AgentId"].ToString();
                cust.Username = custReader["Username"].ToString();
                cust.Password = custReader["Password"].ToString();
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

    [DataObjectMethod(DataObjectMethodType.Update)]
    public static int UpdateCustomer(Customer original_Cust, Customer Cust) //update method
    {
        int indicator = 0;
        SqlConnection connection = TravelExpertsDB.GetConnection();
        string updateStatement = "UPDATE Customers " +
                                 "SET CustomerId = @CustomerId, " +
                                 "    CustFirstName = @CustFirstName, " +
                                 "    CustLastName = @CustLastName, " +
                                 "    CustAddress = @CustAddress, " +
                                 "    CustCity = @CustCity, " +
                                 "    CustProv = @CustProv, " +
                                 "    CustPostal = @CustPostal, " +
                                 "    CustCountry = @CustCountry, " +
                                 "    CustHomePhone = @CustHomePhone, " +
                                 "    CustBusPhone = @CustBusPhone, " +
                                 "    CustEmail = @CustEmail, " +
                                 "    AgentId = @AgentId, " +
                                 "    Username = @Username, " +
                                 "    Password = @Password " +
                                 "WHERE CustomerId = @OldCustomerId " +
                                 "  AND CustFIrstName = @OldCustFirstName " +
                                 "  AND CustLastName = @OldCustLastName " +
                                 "  AND CustAddress = @OldCustAddress " +
                                 "  AND CustCity = @OldCustCity " +
                                 "  AND CustProv = @OldCustProv " +
                                 "  AND CustPostal = @OldCustPostal " +
                                 "  AND CustCountry = @OldCustCountry " +
                                 "  AND CustHomePhone = @OldCustHomePhone " +
                                 "  AND CustBusPhone = @OldCustBusPhone " +
                                 "  AND CustEmail = @OldCustEmail " +
                                 "  AND AgentId = @OldAgentId " +
                                 "  AND Username = @OldUsername " +
                                 "  AND Password = @OldPassword";

        SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
        updateCommand.Parameters.AddWithValue("@OldCustomerId", original_Cust.CustomerId);
        updateCommand.Parameters.AddWithValue("@OldCustFirstName", original_Cust.CustFirstName);
        updateCommand.Parameters.AddWithValue("@OldCustLastName", original_Cust.CustLastName);
        updateCommand.Parameters.AddWithValue("@OldCustAddress", original_Cust.CustAddress);
        updateCommand.Parameters.AddWithValue("@OldCustCity", original_Cust.CustCity);
        updateCommand.Parameters.AddWithValue("@OldCustProv", original_Cust.CustProv);
        updateCommand.Parameters.AddWithValue("@OldCustPostal", original_Cust.CustPostal);
        updateCommand.Parameters.AddWithValue("@OldCustCountry", original_Cust.CustCountry);
        updateCommand.Parameters.AddWithValue("@OldCustHomePhone", original_Cust.CustHomePhone);
        updateCommand.Parameters.AddWithValue("@OldCustBusPhone", original_Cust.CustBusPhone);
        updateCommand.Parameters.AddWithValue("@OldCustEmail", original_Cust.CustEmail);
        if (original_Cust.AgentId == null)
        {
            updateCommand.Parameters.AddWithValue("@OldAgentId", DBNull.Value);
        }
        else
        {
            updateCommand.Parameters.AddWithValue("@OldAgentId", original_Cust.AgentId);
        }
        updateCommand.Parameters.AddWithValue("@OldUsername", original_Cust.Username);
        updateCommand.Parameters.AddWithValue("@OldPassword", original_Cust.Password);
        updateCommand.Parameters.AddWithValue("@CustomerId", Cust.CustomerId);
        updateCommand.Parameters.AddWithValue("@CustFirstName", Cust.CustFirstName);
        updateCommand.Parameters.AddWithValue("@CustLastName", Cust.CustLastName);
        updateCommand.Parameters.AddWithValue("@CustAddress", Cust.CustAddress);
        updateCommand.Parameters.AddWithValue("@CustCity", Cust.CustCity);
        updateCommand.Parameters.AddWithValue("@CustProv", Cust.CustProv);
        updateCommand.Parameters.AddWithValue("@CustPostal", Cust.CustPostal);
        updateCommand.Parameters.AddWithValue("@CustCountry", Cust.CustCountry);
        updateCommand.Parameters.AddWithValue("@CustHomePhone", Cust.CustHomePhone);
        updateCommand.Parameters.AddWithValue("@CustBusPhone", Cust.CustBusPhone);
        updateCommand.Parameters.AddWithValue("@CustEmail", Cust.CustEmail);
        if (Cust.AgentId == null)
        {
            updateCommand.Parameters.AddWithValue("@AgentId", DBNull.Value);
        }
        else
        {
            updateCommand.Parameters.AddWithValue("@AgentId", Cust.AgentId);
        }
        updateCommand.Parameters.AddWithValue("@Username", Cust.Username);
        updateCommand.Parameters.AddWithValue("@Password", Cust.Password);
        try
        {
            connection.Open();
            indicator = updateCommand.ExecuteNonQuery();
            return indicator;
            //if (indicator > 0)
            //{
            //    string selectStatement = "SELECT IDENT_CURRENT('Customers') " +
            //          "FROM Customers";
            //    SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            //    int customerId = int.Parse(selectCommand.ExecuteScalar().ToString()); //first col of the row is selected
            //    return customerId;
            //}
            //else
            //{
            //    return -1;
            //}
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