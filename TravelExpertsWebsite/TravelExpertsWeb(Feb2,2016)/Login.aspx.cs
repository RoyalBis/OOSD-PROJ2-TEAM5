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
// Description: Login page session check, login button event, logout button event 
// </Comment>

public partial class Scripts_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] != null) //check session
        {
            Label lblUser = (Label)Master.FindControl("UserLogin");
            lblUser.Text = "Hello, " + Session["User"].ToString();  //if session display greeting

            Label lblSignout = (Label)Master.FindControl("Sign"); //display signout instead of signin
            lblSignout.Text = "Signout";

            txtLPassword.Visible = false; //change msg on login panel upon login
            txtLUsername.Visible = false;
            login.Visible = false;
            signout.Visible = true;
            lblMsg.Text = "Welcome " + Session["User"].ToString() + ", logout will help you protect your information";
        }
    }

    protected void login_Click(object sender, EventArgs e) //login button event
    {
        Customer myCustomer = new Customer(); //new object to hold username and password
        myCustomer.Username = txtLUsername.Text;
        myCustomer.Password = txtLPassword.Text;

        Customer loggedCustomer = CustomerDB.UserLogin(myCustomer);
        if (loggedCustomer == null ) //msg for login fail
        {
            lblMsg.Text = "Incorrect username or password";
            lblMsg.ForeColor = System.Drawing.Color.Red;
        }
        else //if success, establish new session (firstname, custID) and redirect to booking page
        {
            string custName = loggedCustomer.CustFirstName;
            Session.Add("User", custName);
            int custID = loggedCustomer.CustomerId;
            Session.Add("CustID", custID);
            Label lblUser = (Label)Master.FindControl("UserLogin");
            lblUser.Text = "Hello, " + Session["User"].ToString();
            Response.Redirect("Bookings.aspx");
        }
    }

    protected void signout_Click(object sender, EventArgs e) //destory current sessions
    {
        Session.Abandon();
        Response.Redirect(Request.RawUrl);
    }
}