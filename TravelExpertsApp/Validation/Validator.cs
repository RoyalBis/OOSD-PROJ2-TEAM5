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

        //public static bool IsPresent(TextBox textbox)
        //{
        //    if (textbox.Text == "")
        //    {
        //        MessageBox.Show("Error: " + textbox.Name + " is a required field!");
        //        textbox.Focus();
        //        return false;
        //    }
        //    return true;
        //}

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
                //First unformat the string from the Control
                string textValue = ctrl.Text.Replace("$", "").Replace(",", "");
                decimal decValue = decimal.Parse(textValue);
                if (decValue >= 0) return true;
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
                //First unformat the string from the Control
                string textValue = ctrl.Text.Replace("$", "").Replace(",", "");
                int intValue = int.Parse(textValue);
                if (intValue >= 0) return true;
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

        public static bool DateLessThan(DateTimePicker ctrl1, DateTimePicker ctrl2)
        {
            if ( ctrl1.Value >= ctrl2.Value )
            {
                MessageBox.Show("Error: " + ctrl1.Name + " must be a date less than " + ctrl2.Name);
                return false;
            }
            return true;
        }

        public static bool InCharCount(Control ctrl)
        {
            TextBox txt = (TextBox)ctrl;
            char[] chars = txt.Text.ToCharArray();
            if ( chars.Length > txt.MaxLength )
            {
                MessageBox.Show("Error: Number of characters in " + txt.Name + " must be less then or equal to " + txt.MaxLength);
                return false;
            }
            return true;
        }
    }
}
