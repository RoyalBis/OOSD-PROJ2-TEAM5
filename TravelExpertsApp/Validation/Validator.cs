using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validation
{
    public static class Validator
    {
        //Generic Method to Check if any Control is Empty Text
        public static bool IsPresent(Control ctrl)
        {
            if (ctrl.Text == "")
            {
                MessageBox.Show("Error: " + ctrl.Name + " is a required field!");
                ctrl.Focus();
                return false;
            }
            return true;
        }

        public static bool IsPresent(TextBox textbox)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show("Error: " + textbox.Name + " is a required field!");
                textbox.Focus();
                return false;
            }
            return true;
        }

        //public static bool IsPresentRich(RichTextBox textbox)
        //{
        //    if (textbox.Text == "")
        //    {
        //        MessageBox.Show("Error: " + textbox.Name + " is a required field!");
        //        textbox.Focus();
        //        return false;
        //    }
        //    return true;
        //}

        //public static bool IsPresentDtp(DateTimePicker dtp)
        //{
        //    if (dtp.Text == "")
        //    {
        //        MessageBox.Show("Error: " + dtp.Name + " is a required field!");
        //        dtp.Focus();
        //        return false;
        //    }
        //    return true;
        //}

        //public static bool CodeRegex(TextBox textbox)
        //{
        //    Regex regex = new Regex(@"\w\w\w\w");
        //    Match match = regex.Match(textbox.Text);
        //    if (!match.Success)
        //    {
        //        MessageBox.Show("Product Code must be: 4 characters mixed string of letters and numbers!");
        //        textbox.Focus();
        //        return false;
        //    }
        //    return true;
        //}

        public static bool NonNegDecimal(Control ctrl)
        {
            try
            {
                decimal textValue = decimal.Parse(ctrl.Text);
                if (textValue >= 0) return true;
                else
                {
                    MessageBox.Show("Error: " + ctrl.Name + " must be non-negative value!");
                    ctrl.Focus();
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: " + ctrl.Name + " must be decimal number!");
                ctrl.Focus();
                return false;
            }
        }

        public static bool NonNegInt(Control ctrl)
        {
            try
            {
                int textValue = int.Parse(ctrl.Text);
                if (textValue >= 0) return true;
                else
                {
                    MessageBox.Show("Error: " + ctrl.Name + " must be non-negative value!");
                    ctrl.Focus();
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: " + ctrl.Name + " must be integer number!");
                ctrl.Focus();
                return false;
            }
        }
    }
}
