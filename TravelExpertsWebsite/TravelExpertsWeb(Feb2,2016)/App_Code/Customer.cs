using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Customers
/// </summary>
public class Customer
{
    public Customer() { }
    public int CustomerId { get; set; }
    public string CustFirstName { get; set; }
    public string CustLastName { get; set; }
    public string CustAddress { get; set; }
    public string CustCity { get; set; }
    public string CustProv { get; set; }
    public string CustPostal { get; set; }
    public string CustCountry { get; set; }
    public string CustHomePhone { get; set; }
    public string CustBusPhone { get; set; }
    public string CustEmail { get; set; }
    public string AgentId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}