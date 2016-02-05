using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validation
{
    public static class Validator
    {
        //Generic Method to Check if any Control is Empty Text
        public static Result IsPresent(Control ctrl)
        {
            if (ctrl.Text == "")
            {
                string message = "Please enter a " + ctrl.Tag;
                ctrl.Focus();
                return new Result(false, message);
            }
            return new Result(true);
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

        public static Result NonNegDecimal(Control ctrl)
        {
            try
            {
                //First unformat the string from the Control
                string textValue = ctrl.Text.Replace("$", "").Replace(",", "");
                decimal decValue = decimal.Parse(textValue);
                if (decValue >= 0) return new Result(true);
                else
                {
                    string message = ctrl.Tag + " must be non-negative value!";
                    ctrl.Focus();
                    return new Result(false, message);
                }
            }
            catch (FormatException)
            {
                string message = ctrl.Tag + " must be decimal number!";
                ctrl.Focus();
                return new Result(false, message);
            }
        }

        public static Result NonNegInt(Control ctrl)
        {
            try
            {
                //First unformat the string from the Control
                string textValue = ctrl.Text.Replace("$", "").Replace(",", "");
                int intValue = int.Parse(textValue);
                if (intValue >= 0) return new Result(true);
                else
                {
                    string message = ctrl.Tag + " must be non-negative value!";
                    ctrl.Focus();
                    return new Result(false,message);
                }
            }
            catch (FormatException)
            {
                string message = "Error: " + ctrl.Tag + " must be integer number!";
                ctrl.Focus();
                return new Result(false, message);
            }
        }

        public static Result DateLessThan(DateTimePicker ctrl1, DateTimePicker ctrl2)
        {
            if ( ctrl1.Value >= ctrl2.Value )
            {
                string message = ctrl1.Tag + " must be a date less than " + ctrl2.Tag;
                return new Result(false, message);
            }
            return new Result(true);
        }

        public static Result InCharCount(Control ctrl, int maxlength)
        {
            char[] chars = ctrl.Text.ToCharArray();
            if ( chars.Length > maxlength)
            {
                string message = "Error: Number of characters in " + ctrl.Tag + " must be less then or equal to " + maxlength;
                return new Result(false, message);
            }
            return new Result(true);
        }

        public static Result ValueLessThan(Control ctrl1, Control ctrl2)
        {
            string val1 = ctrl1.Text.Replace("$", "").Replace(",", "");
            string val2 = ctrl2.Text.Replace("$", "").Replace(",", "");

            if ( Convert.ToDouble(val1) >= (Convert.ToDouble(val2)) )
            {
                string message = ctrl1.Tag + " must be less than " + ctrl2.Tag;
                return new Result(false, message);
            }
                return new Result(true);
        }
    }
}
