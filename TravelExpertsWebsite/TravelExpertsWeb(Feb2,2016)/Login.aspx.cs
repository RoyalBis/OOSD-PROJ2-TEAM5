using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Scripts_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] != null)
        {
            Label lblUser = (Label)Master.FindControl("UserLogin");
            lblUser.Text = "Hello, " + Session["User"].ToString();
            txtLPassword.Visible = false;
            txtLUsername.Visible = false;
            login.Visible = false;
            signout.Visible = true;
            lblMsg.Text = "Welcome " + Session["User"].ToString() + ", please logout before making a new registrationS";
        }
    }

    protected void login_Click(object sender, EventArgs e)
    {
        Customer myCustomer = new Customer();
        myCustomer.Username = txtLUsername.Text;
        myCustomer.Password = txtLPassword.Text;

        if (CustomerDB.UserLogin(myCustomer) == null )
        {
            lblMsg.Text = "Incorrect username or password";
            lblMsg.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            string custName = CustomerDB.UserLogin(myCustomer).CustFirstName;
            Session.Add("User", custName);
            int custID = CustomerDB.UserLogin(myCustomer).CustomerId;
            Session.Add("CustID", custID);
            Label lblUser = (Label)Master.FindControl("UserLogin");
            lblUser.Text = "Hello, " + Session["User"].ToString();
            Response.Redirect("Bookings.aspx");
        }
    }

    protected void signout_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect(Request.RawUrl);
    }
}