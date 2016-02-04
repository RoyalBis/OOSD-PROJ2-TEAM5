using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pack : System.Web.UI.Page
{
    public static Package packages;
    protected void Page_Load(object sender, EventArgs e)
    {
        for (int i = 1; i < 17; i++)
            displayPackage(i);

        if (Session["User"] != null)
        {
            Label lblUser = (Label)Master.FindControl("UserLogin");
            lblUser.Text = "Hello, " + Session["User"].ToString();
        }
    }

    private void displayPackage(int packageValue)
    {
        List<Package> selectedPackage = new List<Package>();
        selectedPackage = PackageDB.GetPackage(packageValue);

        try
        {                                    
            string startDate, endDate,basePkg,AgtCmsnPkg,pkgID;
            
            Image pkgImg;
            foreach (Package ValuePackages in selectedPackage)
            {
                Package p = new Package();
                //Add items in an array
                p.PackageId = ValuePackages.PackageId;
                pkgID = p.PackageId.ToString();
                p.PkgName = ValuePackages.PkgName.ToString();
                p.PkgStartDate = ValuePackages.PkgStartDate;
                p.PkgEndDate = ValuePackages.PkgEndDate;
                p.PkgBasePrice = ValuePackages.PkgBasePrice;
                basePkg = p.PkgBasePrice.ToString("c");
                p.PkgDesc = ValuePackages.PkgDesc;
               p.PkgAgencyCommission = ValuePackages.PkgAgencyCommission;
                AgtCmsnPkg = p.PkgAgencyCommission.ToString("c");

                p.PkgImage = ValuePackages.PkgImage;
                pkgImg = FetchImage(pkgID,ValuePackages.PkgImage);
                //add items in the list   

                startDate =p.PkgStartDate.ToString("dd MMMM, yyyy");
                endDate = p.PkgEndDate.ToString("dd MMMM, yyyy");

                displayLabels(pkgID, p.PkgName, startDate, endDate, basePkg, p.PkgDesc, AgtCmsnPkg, p.PkgImage);
            }
                                                                                                               

        }
        catch (Exception ex)
        {
            throw ex;
        }


    }

  

    private Image FetchImage(string pkgID, byte[] pkgImage)
    {
        Image img = new Image();
        string imgID = "_";
        imgID += pkgID;
        img.ID = imgID;
        
        if (img.ID != "0")
        {
            string base64String = Convert.ToBase64String(pkgImage, 0, pkgImage.Length);
            img.ImageUrl = "data:image"+imgID+"/png;base64," + base64String;

            return img;
        }
        return null;
    }

    
    private void displayLabels(string pkgID, string pkgName, string startDate, string endDate, string basePkg, string pkDesc, string agtCmsnPkg, byte[] pkgImage )
    {
        
        if (Convert.ToInt32(pkgID.ToString()) == 1)
        {

           
            Label12.Text = pkgName.ToString();
            Label13.Text = startDate.ToString();
            Label14.Text = endDate.ToString();
            Label15.Text = basePkg.ToString();
            Label16.Text = pkDesc.ToString();
            Label17.Text = agtCmsnPkg.ToString();
            _1.ImageUrl = getImgUrl(pkgID,pkgImage);

        }
        if (Convert.ToInt32(pkgID.ToString()) == 2)
        {
            
            Label22.Text = pkgName.ToString();
            Label23.Text = startDate.ToString();
            Label24.Text = endDate.ToString();
            Label25.Text = basePkg.ToString();
            Label26.Text = pkDesc.ToString();
            Label27.Text = agtCmsnPkg.ToString();
            _2.ImageUrl = getImgUrl(pkgID, pkgImage);


        }
        if (Convert.ToInt32(pkgID.ToString()) == 3)
        {
      
            Label32.Text = pkgName.ToString();
            Label33.Text = startDate.ToString();
            Label34.Text = endDate.ToString();
            Label35.Text = basePkg.ToString();
            Label36.Text = pkDesc.ToString();
            Label37.Text = agtCmsnPkg.ToString();
            _3.ImageUrl = getImgUrl(pkgID, pkgImage);
            
        }
        if (Convert.ToInt32(pkgID.ToString()) == 4)
        {
            
            Label42.Text = pkgName.ToString();
            Label43.Text = startDate.ToString();
            Label44.Text = endDate.ToString();
            Label45.Text = basePkg.ToString();
            Label46.Text = pkDesc.ToString();
            Label47.Text = agtCmsnPkg.ToString();
            _4.ImageUrl = getImgUrl(pkgID, pkgImage);
            
        }
        if (Convert.ToInt32(pkgID.ToString()) == 5)
        {
           
            Label52.Text = pkgName.ToString();
            Label53.Text = startDate.ToString();
            Label54.Text = endDate.ToString();
            Label55.Text = basePkg.ToString();
            Label56.Text = pkDesc.ToString();
            Label57.Text = agtCmsnPkg.ToString();
            _5.ImageUrl = getImgUrl(pkgID, pkgImage);
        }
        if (Convert.ToInt32(pkgID.ToString()) == 6)
        {
           
            Label62.Text = pkgName.ToString();
            Label63.Text = startDate.ToString();
            Label64.Text = endDate.ToString();
            Label65.Text = basePkg.ToString();
            Label66.Text = pkDesc.ToString();
            Label67.Text = agtCmsnPkg.ToString();

            _6.ImageUrl = getImgUrl(pkgID, pkgImage);
        }
        if (Convert.ToInt32(pkgID.ToString()) == 7)
        {
           
            Label72.Text = pkgName.ToString();
            Label73.Text = startDate.ToString();
            Label74.Text = endDate.ToString();
            Label75.Text = basePkg.ToString();
            Label76.Text = pkDesc.ToString();
            Label77.Text = agtCmsnPkg.ToString();

            _7.ImageUrl = getImgUrl(pkgID, pkgImage);
        }
        if (Convert.ToInt32(pkgID.ToString()) == 8)
        {
            
            Label82.Text = pkgName.ToString();
            Label83.Text = startDate.ToString();
            Label84.Text = endDate.ToString();
            Label85.Text = basePkg.ToString();
            Label86.Text = pkDesc.ToString();
            Label87.Text = agtCmsnPkg.ToString();

            _8.ImageUrl = getImgUrl(pkgID, pkgImage);
        }
        if (Convert.ToInt32(pkgID.ToString()) == 9)
        {
           
            Label92.Text = pkgName.ToString();
            Label93.Text = startDate.ToString();
            Label94.Text = endDate.ToString();
            Label95.Text = basePkg.ToString();
            Label96.Text = pkDesc.ToString();
            Label97.Text = agtCmsnPkg.ToString();

            _9.ImageUrl = getImgUrl(pkgID, pkgImage);
        }
        if (Convert.ToInt32(pkgID.ToString()) == 10)
        {
        
            Label102.Text = pkgName.ToString();
            Label103.Text = startDate.ToString();
            Label104.Text = endDate.ToString();
            Label105.Text = basePkg.ToString();
            Label106.Text = pkDesc.ToString();
            Label107.Text = agtCmsnPkg.ToString();

            _10.ImageUrl = getImgUrl(pkgID, pkgImage);
        }
        if (Convert.ToInt32(pkgID.ToString()) == 11)
        {
          
            Label112.Text = pkgName.ToString();
            Label113.Text = startDate.ToString();
            Label114.Text = endDate.ToString();
            Label115.Text = basePkg.ToString();
            Label116.Text = pkDesc.ToString();
            Label117.Text = agtCmsnPkg.ToString();

            _11.ImageUrl = getImgUrl(pkgID, pkgImage);
        }
        if (Convert.ToInt32(pkgID.ToString()) == 12)
        {
           
            Label122.Text = pkgName.ToString();
            Label123.Text = startDate.ToString();
            Label124.Text = endDate.ToString();
            Label125.Text = basePkg.ToString();
            Label126.Text = pkDesc.ToString();
            Label127.Text = agtCmsnPkg.ToString();

            _12.ImageUrl = getImgUrl(pkgID, pkgImage);
        }
        if (Convert.ToInt32(pkgID.ToString()) == 13)
        {
           
            Label132.Text = pkgName.ToString();
            Label133.Text = startDate.ToString();
            Label134.Text = endDate.ToString();
            Label135.Text = basePkg.ToString();
            Label136.Text = pkDesc.ToString();
            Label137.Text = agtCmsnPkg.ToString();

            _13.ImageUrl = getImgUrl(pkgID, pkgImage);
        }
        if (Convert.ToInt32(pkgID.ToString()) == 14)
        {
           
            Label142.Text = pkgName.ToString();
            Label143.Text = startDate.ToString();
            Label144.Text = endDate.ToString();
            Label145.Text = basePkg.ToString();
            Label146.Text = pkDesc.ToString();
            Label147.Text = agtCmsnPkg.ToString();

            _14.ImageUrl = getImgUrl(pkgID, pkgImage);
        }
        if (Convert.ToInt32(pkgID.ToString()) == 16)
        {
            
            Label152.Text = pkgName.ToString();
            Label153.Text = startDate.ToString();
            Label154.Text = endDate.ToString();
            Label155.Text = basePkg.ToString();
            Label156.Text = pkDesc.ToString();
            Label157.Text = agtCmsnPkg.ToString();

            _15.ImageUrl = getImgUrl(pkgID, pkgImage);
        }
    }

    private string getImgUrl(string pkgID, byte[] pkgImage)
    {

        Image img = new Image();
        string imgID = "_";
        imgID += pkgID;
        img.ID = imgID;

        if (img.ID != "0")
        {
            string base64String = Convert.ToBase64String(pkgImage, 0, pkgImage.Length);
            img.ImageUrl = "data:image" + imgID + "/png;base64," + base64String;

            return img.ImageUrl;
        }
        return null;
    }

    public System.Drawing.Image getImageFromBytes(byte[] myImage)
    {
        if (myImage.Length > 0)
        {
            using (MemoryStream ms = new MemoryStream(myImage))
            {
                //Still need this, because It could fail.

                System.Drawing.Image myBitmap = System.Drawing.Image.FromStream(ms);

                return myBitmap;
            }
        }
        return null;
    }

   

}