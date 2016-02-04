using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack){}

        if (Session["User"] != null)
        {
            Response.Redirect("login.aspx");
        }
    }

    protected void submit_Click(object sender, EventArgs e)
    {
                Customer newCustomer = new Customer();
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
                CustomerDB.AddCustomer(newCustomer);

                Customer loggedCustomerNew = CustomerDB.UserLogin(newCustomer);
                string custName = loggedCustomerNew.CustFirstName;
                Session.Add("User", custName);
                int custID = loggedCustomerNew.CustomerId;
                Session.Add("CustID", custID);
                Label lblUser = (Label)Master.FindControl("UserLogin");
                lblUser.Text = "Hello, " + Session["User"].ToString();
                Response.Redirect("Bookings.aspx");
    }
}