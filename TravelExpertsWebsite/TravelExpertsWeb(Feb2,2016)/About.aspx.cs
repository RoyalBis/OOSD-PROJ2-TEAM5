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
// Description: About page session check 
// </Comment>

public partial class About : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] != null)
        {
            Label lblUser = (Label)Master.FindControl("UserLogin");
            lblUser.Text = "Hello, " + Session["User"].ToString();

            Label lblSignout = (Label)Master.FindControl("Sign");
            lblSignout.Text = "Signout";
        }
    }
}