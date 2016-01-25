using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using MaterialSkin;
using MaterialSkin.Controls;
using TravelExpertsDB;
using Validation;

namespace TravelExpertsApp
{
    public partial class frmPkgAddModify : MaterialForm
    {
        private PackageList packages;
        public Package PkgIn;
        public Package PkgOut = new Package();
        public bool Add;
        private MaterialSkinManager materialSkinManager;

        public frmPkgAddModify()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            packages = PackagesTable.GetAllPackages();
            if ( !Add )
            {
                ProductSupplierTable.GetProductSuppliers(PkgIn);
                this.Text = "Modify Package " + PkgIn.PackageId;
                btnAddModify.Text = "Update";
                SetActive();
            }
        }

        private void SetActive()
        {
            txtPkgName.Text = PkgIn.PkgName;
            MaterialComboBoxItem cbItem1 = new MaterialComboBoxItem("Hello");
            MaterialComboBoxItem cbItem2 = new MaterialComboBoxItem("Royal");
            MaterialComboBoxItem cbItem3 = new MaterialComboBoxItem("Bissell");
            txtPkgName.Add(cbItem1);
            txtPkgName.Add(cbItem2);
            txtPkgName.Add(cbItem3);
            dtpStartDate.Value = PkgIn.PkgStartDate;
            dtpEndDate.Value = PkgIn.PkgEndDate;
            txtDesc.Text = PkgIn.PkgDesc;
            txtBasePrice.Text = PkgIn.PkgBasePrice.ToString("c");
            txtCommission.Text = PkgIn.PkgAgencyCommission.ToString("c");
            try
            {
                pbPkgImage.Image = PkgIn.ImageFromBytes();
                //For Some Reason I have to Write a File, then convert it into an image from a file.
                File.WriteAllBytes("myImage.jpg", PkgIn.PkgImage);
                pbPkgImage.Image = Image.FromFile("myImage.jpg");
                //File.Delete("myImage.jpg"); //just delete it when I am done with it
            }
            catch ( Exception e )
            {
                MessageBox.Show(e.Message);
            }

            //Fill the List view with the Product Suppliers
            var ps = PkgIn.PkgProductSuppliers;
            for (int i = 0; i < ps.Count; i++)
            {
                //lvPkgProductSuppliers.Items.Add((ps[i]))
                lvPkgProductSuppliers.Items.Add(ps[i].ProductSupplierId.ToString());
                lvPkgProductSuppliers.Items[i].SubItems.Add(ps[i].MyProduct.ProdName);
                lvPkgProductSuppliers.Items[i].SubItems.Add(ps[i].MySupplier.SupName);
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdImage.ShowDialog();
            if ( result == DialogResult.OK )
            {
                string path = ofdImage.FileName;

                Image myImage = Image.FromFile(path);
                pbPkgImage.Image = myImage;
                pbPkgImage.Tag = path;
            }
        }

        private void btnAddModify_Click(object sender, EventArgs e)
        {
            if ( isValid() )
            {
                ImageConverter converter = new ImageConverter();
                byte[] imgArray = (byte[])converter.ConvertTo(pbPkgImage.Image, typeof(byte[]));
                string basePrice = txtBasePrice.Text.Replace("$", "");
                string commission = txtCommission.Text.Replace("$", "");

                PkgOut.PkgName = txtPkgName.Text;
                PkgOut.PkgStartDate = dtpStartDate.Value;
                PkgOut.PkgEndDate = dtpEndDate.Value;
                PkgOut.PkgDesc = txtDesc.Text;
                PkgOut.PkgBasePrice = Convert.ToDecimal(basePrice);
                PkgOut.PkgAgencyCommission = Convert.ToDecimal(commission);
                PkgOut.PkgImage = imgArray;
                int[] prodSupIds = new int[lvPkgProductSuppliers.Items.Count];
                for (int i = 0; i < lvPkgProductSuppliers.Items.Count; i++)
                {
                    prodSupIds[i] = Convert.ToInt32(lvPkgProductSuppliers.Items[i].Text);
                }
                PkgOut.PkgProductSuppliers.AddRange(ProductSupplierTable.GetRangeProductSuppliers(prodSupIds));

                if (Add)
                {
                    PkgOut.PackageId = PackagesTable.AddPackage(PkgOut);
                    AddProductSuppliers(PkgOut);
                }
                else
                {
                    PackagesTable.UpdatePackage(PkgIn, PkgOut);
                    UpdateProductSuppliers(PkgIn, PkgOut);
                }
                PkgIn = PkgOut;
            }
            this.Close();
        }

        private void UpdateProductSuppliers(Package PkgIn,Package PkgOut)
        {
            foreach (ProductSupplier prodsup in PkgIn.PkgProductSuppliers)
            {
                if ( !PkgOut.PkgProductSuppliers.Contains(prodsup) )
                {
                    PackagesProductsSuppliersTable.DeletePkgProdSup(PkgIn.PackageId, prodsup);
                }
            }

            foreach (ProductSupplier prodsup in PkgOut.PkgProductSuppliers)
            {
                if (!PkgIn.PkgProductSuppliers.Contains(prodsup) )
                {
                    PackagesProductsSuppliersTable.AddSupplier(PkgIn.PackageId, prodsup);
                }
            }
        }

        private void AddProductSuppliers(Package PkgOut)
        {
            foreach (ProductSupplier prodsup in PkgOut.PkgProductSuppliers)
            {
                PackagesProductsSuppliersTable.AddSupplier(PkgOut.PackageId, prodsup);
            }
        }

        private bool isValid()
        {
            return Validator.IsPresent(txtPkgName) &&
                   Validator.IsPresent(txtDesc) &&
                   Validator.IsPresent(txtBasePrice) &&
                   Validator.NonNegDecimal(txtBasePrice) &&
                   Validator.NonNegDecimal(txtCommission) &&
                   Validator.DateLessThan(dtpStartDate, dtpEndDate);
                   //Validator.InCharCount(txtPkgName) &&
                   //Validator.InCharCount(txtDesc) &&
                   //Validator.InCharCount(txtBasePrice) &&
                   //Validator.InCharCount(txtCommission);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ( this.panDock.Controls.Find("DockProdSupSearch",false).Length != 0 )
            {
                return;
            }
            DockProdSupSearch userCtrl = new DockProdSupSearch();
            userCtrl.UpdateControl = lvPkgProductSuppliers;
            userCtrl.Show();
            userCtrl.Dock = DockStyle.Fill;
            panDock.Width = userCtrl.Width;
            this.panDock.Controls.Add(userCtrl);
            this.Size = new Size(this.Width + userCtrl.Width, this.Height);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPSDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvPkgProductSuppliers.SelectedItems)
            {
                lvPkgProductSuppliers.Items.Remove(item);
            }
        }
    }
}
