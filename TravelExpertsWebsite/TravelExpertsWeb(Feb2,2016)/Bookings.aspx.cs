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
// Description: Booking page session check 
// </Comment>

public partial class Bookings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CustID"] == null) //check session
        {
            Response.Redirect("login.aspx"); //direct back to login if no session
        }
        else
        {
            int CustID = int.Parse(Session["CustID"].ToString()); 
            List<BookingDetail> list = CustomerDB.UserBooking(CustID); //use session as input to user booking details 
            
            gvBooking.DataSource = list;
            gvBooking.DataBind(); //bind the bookingDetail list to gridview for display
            lblTotal.Text = CustomerDB.GetTotal(CustID).ToString("c"); //get total price


            Customer thisCustomer = CustomerDB.SelectThisCustomer(CustID); //display greeting to replace login on navbar

            lblUsername.Text = "Welcome " + Session["User"].ToString();
            Label lblUser = (Label)Master.FindControl("UserLogin");
            lblUser.Text = "Hello, " + Session["User"].ToString();

            Label lblSignout = (Label)Master.FindControl("Sign"); //replace signin wih signout
            lblSignout.Text = "Signout";

            gvBooking.Font.Size = FontUnit.XSmall; //style fontsize for gridview
            dvCustomer.Font.Size = FontUnit.XSmall; //style fontsize for detailview

        }
    }
}