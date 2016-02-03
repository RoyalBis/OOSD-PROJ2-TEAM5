using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pack : System.Web.UI.Page
{
    public static Package packages;
    protected void Page_Load(object sender, EventArgs e)
    {
        for (int i = 1; i < 5; i++)
            displayPackage(i);
    }

    private void displayPackage(int packageValue)
    {
        List<Package> selectedPackage = new List<Package>();
        selectedPackage = PackageDB.GetPackage(packageValue);

        try
        {
            string[] arr = new string[7];
            DateTime startDate, endDate;
            foreach (Package ValuePackages in selectedPackage)
            {

                //Add items in an array
                arr[0] = ValuePackages.PackageId.ToString();
                arr[1] = ValuePackages.PkgName.ToString();
                arr[2] = ValuePackages.PkgStartDate.ToString();
                arr[3] = ValuePackages.PkgEndDate.ToString();
                arr[4] = ValuePackages.PkgBasePrice.ToString("c");
                arr[5] = ValuePackages.PkgDesc.ToString();
                arr[6] = ValuePackages.PkgAgencyCommission.ToString("c");
                //add items in the list   
                arr[2]=arr[2].Replace("12:00:00 AM", "");
                startDate =Convert.ToDateTime(arr[2]);
                arr[2]= startDate.ToString("dd MMMM, yyyy");

                arr[3] = arr[3].Replace("12:00:00 AM", "");
                endDate = Convert.ToDateTime(arr[3]);
                arr[3] = endDate.ToString("dd MMMM, yyyy");

            }

            displayLabels(arr[0].ToString(), arr[1].ToString(), arr[2], arr[3].ToString(), arr[4].ToString(), arr[5].ToString(), arr[6].ToString());


        }
        catch (Exception ex)
        {
            throw ex;
        }


    }

    public void displayLabels(string v1, string v2, string v3, string v4, string v5, string v6, string v7)
    {
        if (Convert.ToInt32(v1.ToString()) == 1)
        {
            Label11.Text = v1.ToString();
            Label12.Text = v2.ToString();
            Label13.Text = v3.ToString();
            Label14.Text = v4.ToString();
            Label15.Text = v5.ToString();
            Label16.Text = v6.ToString();
            Label17.Text = v7.ToString();
        }
        if (Convert.ToInt32(v1.ToString()) == 2)
        {
            Label21.Text = v1.ToString();
            Label22.Text = v2.ToString();
            Label23.Text = v3.ToString();
            Label24.Text = v4.ToString();
            Label25.Text = v5.ToString();
            Label26.Text = v6.ToString();
            Label27.Text = v7.ToString();
        }
        if (Convert.ToInt32(v1.ToString()) == 3)
        {
            Label31.Text = v1.ToString();
            Label32.Text = v2.ToString();
            Label33.Text = v3.ToString();
            Label34.Text = v4.ToString();
            Label35.Text = v5.ToString();
            Label36.Text = v6.ToString();
            Label37.Text = v7.ToString();
        }
        if (Convert.ToInt32(v1.ToString()) == 4)
        {
            Label41.Text = v1.ToString();
            Label42.Text = v2.ToString();
            Label43.Text = v3.ToString();
            Label44.Text = v4.ToString();
            Label45.Text = v5.ToString();
            Label46.Text = v6.ToString();
            Label47.Text = v7.ToString();
        }
        if (Convert.ToInt32(v1.ToString()) == 5)
        {
            Label51.Text = v1.ToString();
            Label52.Text = v2.ToString();
            Label53.Text = v3.ToString();
            Label54.Text = v4.ToString();
            Label55.Text = v5.ToString();
            Label56.Text = v6.ToString();
            Label57.Text = v7.ToString();
        }
        if (Convert.ToInt32(v1.ToString()) == 6)
        {
            Label61.Text = v1.ToString();
            Label62.Text = v2.ToString();
            Label63.Text = v3.ToString();
            Label64.Text = v4.ToString();
            Label65.Text = v5.ToString();
            Label66.Text = v6.ToString();
            Label67.Text = v7.ToString();
        }
        if (Convert.ToInt32(v1.ToString()) == 7)
        {
            Label71.Text = v1.ToString();
            Label72.Text = v2.ToString();
            Label73.Text = v3.ToString();
            Label74.Text = v4.ToString();
            Label75.Text = v5.ToString();
            Label76.Text = v6.ToString();
            Label77.Text = v7.ToString();
        }
        if (Convert.ToInt32(v1.ToString()) == 8)
        {
            Label81.Text = v1.ToString();
            Label82.Text = v2.ToString();
            Label83.Text = v3.ToString();
            Label84.Text = v4.ToString();
            Label85.Text = v5.ToString();
            Label86.Text = v6.ToString();
            Label87.Text = v7.ToString();
        }
        if (v1.ToString() == "")
        {
            Label81.Text = "No Data";
            Label82.Text = v2.ToString();
            Label83.Text = v3.ToString();
            Label84.Text = v4.ToString();
            Label85.Text = v5.ToString();
            Label86.Text = v6.ToString();
            Label87.Text = v7.ToString();
        }

    }

}