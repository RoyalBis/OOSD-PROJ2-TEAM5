using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PackageDisplay : System.Web.UI.Page
{
    public static Package packages;
    protected void Page_Load(object sender, EventArgs e)
    {
        string displayThis = Server.UrlDecode(Request.QueryString["myButton"]);
        string packgeValue=  displayThis.Replace("_", "");
        lblDis.Text = packgeValue;
        int pck = Convert.ToInt32(packgeValue);
        displayPackage(pck);
    }

    private void displayPackage(int packageValue)
    {
        List<Package> selectedPackage = new List<Package>();
        selectedPackage = PackageDB.GetPackage(packageValue);

        try
        {
            string[] arr = new string[7];
            foreach (Package ValuePackages in selectedPackage)
            {

                //Add items in an array
                arr[0] = ValuePackages.PackageId.ToString();
                arr[1] = ValuePackages.PkgName.ToString();
                arr[2] = ValuePackages.PkgStartDate.ToString();
                arr[3] = ValuePackages.PkgEndDate.ToString();
                arr[4] = ValuePackages.PkgBasePrice.ToString();
                arr[5] = ValuePackages.PkgDesc.ToString();
                arr[6] = ValuePackages.PkgAgencyCommission.ToString();
                //add items in the list


            }
                                 
            Label1.Text = arr[0];
            Label2.Text = arr[1];
            Label3.Text = arr[2];
            Label4.Text = arr[3];
            Label5.Text = arr[4];
            Label6.Text = arr[5];
            Label7.Text = arr[6];


        }
        catch (Exception ex)
        {
            throw ex;
        }


    }
}