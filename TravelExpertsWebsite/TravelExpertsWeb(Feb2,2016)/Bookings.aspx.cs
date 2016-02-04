using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bookings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["CustID"] == null)
        {
            Response.Redirect("login.aspx");
        }
        else
        {
            int CustID = int.Parse(Session["CustID"].ToString());
            List<BookingDetail> list = CustomerDB.UserBooking(CustID);
            gvBooking.DataSource = list;
            gvBooking.DataBind();

            Customer thisCustomer = CustomerDB.SelectThisCustomer(CustID);

            lblUsername.Text = "Welcome " + Session["User"].ToString();
            Label lblUser = (Label)Master.FindControl("UserLogin");
            lblUser.Text = "Hello, " + Session["User"].ToString();

            gvBooking.Font.Size = FontUnit.XSmall;
            dvCustomer.Font.Size = FontUnit.XSmall;
        }
    }
}