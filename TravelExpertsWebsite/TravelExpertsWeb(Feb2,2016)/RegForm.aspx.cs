using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// <Code Comment>
// Author: Kevin Liao
// Date: Jan 28, 2016
// Class: OOSD Oct 2015
// Description: Reg page session check, method submit 
// </Comment>

public partial class RegForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack){}

        if (Session["User"] != null)
        {
            Response.Redirect("login.aspx"); //redirect to login, cant sign up if already logged as a customer
        }
    }

    protected void submit_Click(object sender, EventArgs e) //submit button event handler
    {
                Customer newCustomer = new Customer(); //new customer object with entered info
                newCustomer.Username = inpUsername.Value;
                newCustomer.Password = inpPassword.Value;
                newCustomer.CustFirstName = inpFirstName.Value;
                newCustomer.CustLastName = inpLastName.Value;
                newCustomer.CustAddress = inpAddress.Value;
                newCustomer.CustCity = inpCity.Value;
                newCustomer.CustProv = inpProvince.Value;
                newCustomer.CustPostal = inpPostal.Value;
                newCustomer.CustCountry = inpCountry.Value;
                newCustomer.CustHomePhone = inpHomePhone.Value;
                newCustomer.CustBusPhone = inpBusPhone.Value;
                newCustomer.CustEmail = inpEmail.Value;
                //newCustomer.AgentId = inpAgentID;
                CustomerDB.AddCustomer(newCustomer); //call add user method

                Customer loggedCustomerNew = CustomerDB.UserLogin(newCustomer); //call login method to log the newly regstered user
                string custName = loggedCustomerNew.CustFirstName;
                Session.Add("User", custName);  //create new sessions
                int custID = loggedCustomerNew.CustomerId;
                Session.Add("CustID", custID);
                Label lblUser = (Label)Master.FindControl("UserLogin"); //display welcome
                lblUser.Text = "Hello, " + Session["User"].ToString(); 
                Response.Redirect("Bookings.aspx"); //redirect to booking
    }
}