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
        /// <summary>
        /// Generic Method to Check if any Control is Empty Text and Return a Message on Failure
        /// </summary>
        /// <param name="ctrl">Control</param>
        /// <returns>Result Object</returns>
        public static Result IsPresent(Control ctrl)
        {
            //if the control.text property is empty then return false, else return true
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

        /// <summary>
        /// Checks if a Control's Text Property has a decimal number that is not less than 0
        /// </summary>
        /// <param name="ctrl">Control</param>
        /// <returns>Result Object</returns>
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
                    //failed so it must be negative
                    string message = ctrl.Tag + " must be non-negative value!";
                    ctrl.Focus();
                    return new Result(false, message);
                }
            }
            catch (FormatException)
            {
                //excpetion so it must not be a decimal number
                string message = ctrl.Tag + " must be decimal number!";
                ctrl.Focus();
                return new Result(false, message);
            }
        }

        /// <summary>
        /// Checks if a Control's Text Property has a Interger number that is not less than 0
        /// </summary>
        /// <param name="ctrl">Control</param>
        /// <returns>Result Object</returns>
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
                    //failed so it must be negative
                    string message = ctrl.Tag + " must be non-negative value!";
                    ctrl.Focus();
                    return new Result(false,message);
                }
            }
            catch (FormatException)
            {
                //excpetion so it must not be a integer number
                string message = "Error: " + ctrl.Tag + " must be integer number!";
                ctrl.Focus();
                return new Result(false, message);
            }
        }

        /// <summary>
        /// Checks if the first date is less then the second date and succeeds if it is
        /// </summary>
        /// <param name="ctrl1">DateTimePicker</param>
        /// <param name="ctrl2">DateTimePicker</param>
        /// <returns>Results Object</returns>
        public static Result DateLessThan(DateTimePicker ctrl1, DateTimePicker ctrl2)
        {
            if ( ctrl1.Value >= ctrl2.Value )
            {
                //failed, ctrl1 date is greater than ctrl2 date
                string message = ctrl1.Tag + " must be a date less than " + ctrl2.Tag;
                return new Result(false, message);
            }
            //success!
            return new Result(true);
        }

        /// <summary>
        /// Checks if a Control's Text has a number of characaters less than the passed in value, will also strip away money formatting if money = true
        /// </summary>
        /// <param name="ctrl">Control</param>
        /// <param name="maxlength">int</param>
        /// <param name="money">bool</param>
        /// <returns>Results Object</returns>
        public static Result InCharCount(Control ctrl, int maxlength, bool money = false)
        {
            //if money is true, strip away money formatting
            string text = (money) ? ctrl.Text.Replace("$", "").Replace(",", "") : ctrl.Text;

            //turn the text into a char array
            char[] chars = text.ToCharArray();
            //check if the char array is greater than the max length
            if ( chars.Length > maxlength)
            {
                //it was greater than so it failed
                string message = "Error: Number of characters in " + ctrl.Tag + " must be less then or equal to " + maxlength;
                return new Result(false, message);
            }
            //sucess!
            return new Result(true);
        }

        /// <summary>
        /// Checks if the first controls value  is less then the second controls value and succeeds if it is
        /// </summary>
        /// <param name="ctrl1">Control</param>
        /// <param name="ctrl2">Control</param>
        /// <returns>Results Object</returns>
        public static Result ValueLessThan(Control ctrl1, Control ctrl2)
        {
            //remove money formatting
            string val1 = ctrl1.Text.Replace("$", "").Replace(",", "");
            string val2 = ctrl2.Text.Replace("$", "").Replace(",", "");

            try
            {
                if ( Decimal.Parse(val1) >= (Decimal.Parse(val2)) )
                {
                    //control 1 was greater than control 2 so return a failure message
                    string message = ctrl1.Tag + " must be less than " + ctrl2.Tag;
                    ctrl1.Focus();
                    return new Result(false, message);
                }
                //Success!
                return new Result(true);
            }
            catch (FormatException)
            {
                //something wasn't a decimal number
                string message = "Error: " + ctrl1.Tag + " and " + ctrl2.Tag + " must be decimal number!";
                return new Result(false, message);
            }
        }
    }
}
