using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace MaterialSkin.Controls
{
    public class MaterialComboBoxItem
    {
        public MaterialComboBoxItem()
        {
            this.MaterialControl = new MaterialSingleLineTextField();
            this.MaterialControl.TabStop = false;
        }

        public MaterialComboBoxItem(string value) : this() 
        {
            this.Value = value;
            this.MaterialControl.Text = value;
            this.MaterialControl.BackColor = Color.White;
        }
        
        public string Value { get; set; }
        public MaterialSingleLineTextField MaterialControl { get; set; }
    }

    public class MaterialComboBox : MaterialSingleLineTextField
    {
        private List<MaterialComboBoxItem> Items = new List<MaterialComboBoxItem>();
        private Panel dropdownPanel;
        private int selection = -1;

        public MaterialComboBox()
        {
            this.dropdownPanel = new Panel();
            dropdownPanel.BorderStyle = BorderStyle.FixedSingle;
            //this.dropdownPanel.Disposed += new EventHandler(DropDownPanelOnDisposed);
            this.dropdownPanel.VisibleChanged += new EventHandler(DropDownPanel_VisibleChanged);
            this.KeyDown += new KeyEventHandler(this.OnKeyDown_UpDown);
            this.KeyUp += new KeyEventHandler(this.OnKeyUp_Enter);
            this.LostFocus += new EventHandler(this.MaterialCB_OnLostFocus);
            this.Enter += new EventHandler(this.MaterialCB_OnEnter);
        }

        private void DropDownPanel_VisibleChanged(object sender, EventArgs e)
        {
            this.selection = -1;
        }

        private void DropDownPanelResize()
        {
            this.dropdownPanel.Size = new Size(base.Width, this.Height * Items.Count);
        }

        private void MaterialCB_OnEnter(object sender, EventArgs e)
        {
            this.dropdownPanel.Location = new Point(base.Left, base.Top + base.Height);
            this.dropdownPanel.Size = new Size(base.Width, this.Height * Items.Count);
            this.Parent.Controls.Add(dropdownPanel);
            this.dropdownPanel.Visible = true;
            this.dropdownPanel.BringToFront();
        }

        private void MaterialCB_OnLostFocus(object sender, EventArgs e)
        {
            selection = -1;
        }

        private void OnKeyUp_Enter(object sender, KeyEventArgs e)
        {
            int i = selection;
            int n = Items.Count;
            if (e.KeyCode == Keys.Enter)
            {
                if (i >= 0 && i <= n - 1)
                {
                    dropdownPanel.Visible = false;
                }
            }
        }

        private void OnKeyDown_UpDown(object sender, KeyEventArgs e)
        {
            int i = selection;
            int n = Items.Count;
            if (e.KeyCode == Keys.Down)
            {
                i++;
                if (i >= 0 && i <= n - 1)
                {
                    if (i != 0)
                    {
                        Items[i - 1].MaterialControl.BackColor = MaterialSkinManager.Instance.GetApplicationBackgroundColor(); ;
                    }
                    Items[i].MaterialControl.BackColor = MaterialSkinManager.Instance.ColorScheme.AccentColor;
                    base.Text = Items[i].Value;
                    this.selection = i;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                i--;
                if (i >= 0 && i <= n - 1)
                {
                    if (i != n)
                    {
                        Items[i + 1].MaterialControl.BackColor = MaterialSkinManager.Instance.GetApplicationBackgroundColor();
                    }
                    Items[i].MaterialControl.BackColor = MaterialSkinManager.Instance.ColorScheme.AccentColor;
                    base.Text = Items[i].Value;
                    this.selection = i;
                }
            }
        }

        public void Add(MaterialComboBoxItem item)
        {
            item.MaterialControl.Location = new Point(0, (Items.Count) * this.Height);
            item.MaterialControl.Size = this.Size;
            item.MaterialControl.Click += new EventHandler(this.ItemSelected);
            this.dropdownPanel.Controls.Add(item.MaterialControl);

            //this.panProdSupId.Controls.Add(this.mtxtProdSupIdItems[i]);
            Items.Add(item);
            DropDownPanelResize();
        }

        private void ItemSelected(object sender, EventArgs e)
        {
            TextBox item = (TextBox)sender;
            base.Text = item.Text;
            dropdownPanel.Visible = false;
        }

        public void Remove(MaterialComboBoxItem item)
        {
            this.dropdownPanel.Controls.Remove(item.MaterialControl);
            this.Items.Remove(item);
            DropDownPanelResize();
        }

        public new void Clear()
        {
            this.dropdownPanel.Controls.Clear();
            this.Items.Clear();
            base.Clear();
            DropDownPanelResize();
        }

        //public void DropDownPanelOnDisposed(object sender, EventArgs eventArgs)
        //{
        //    this.selection = -1;
        //}

        //private void mtxtProdSupId_Enter(object sender, EventArgs e)
        //{
        //    mtxtProdSupIdItems = new List<MaterialSingleLineTextField>();
        //    panProdSupId = new Panel();
        //    panProdSupId.Name = "panProdSupId";
        //    panProdSupId.Location = new Point(mtxtProdSupId.Left, mtxtProdSupId.Top + mtxtProdSupId.Height);
        //    panProdSupId.Size = new Size(mtxtProdSupId.Width, mtxtProdSupId.Height * myStrings.Count);
        //    panProdSupId.Disposed += PanProdSupIdOnDisposed;
        //    this.Controls.Add(this.panProdSupId);

        //    for (int i = 0; i < myStrings.Count; i++)
        //    {
        //        mtxtProdSupIdItems.Add(new MaterialSingleLineTextField());
        //        mtxtProdSupIdItems[i].Name = myStrings[i];
        //        mtxtProdSupIdItems[i].Location = new Point(0, (i) * mtxtProdSupId.Height);
        //        mtxtProdSupIdItems[i].Size = mtxtProdSupId.Size;
        //        mtxtProdSupIdItems[i].Text = myStrings[i];
        //        mtxtProdSupIdItems[i].TabStop = false;
        //        mtxtProdSupIdItems[i].Click += new EventHandler(this.mtxtProdSupId_ItemSelected);
        //        this.panProdSupId.Controls.Add(this.mtxtProdSupIdItems[i]);
        //    }
        //}
    }
}
