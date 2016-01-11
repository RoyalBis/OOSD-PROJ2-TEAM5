using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validation
{
    public class Validator
    {
        //public static bool IsPresent(Control ctrl)
        //{
        //    if (ctrl.Text == "")
        //    {
        //        MessageBox.Show("Error: " + ctrl.Name + " is a required field!");
        //        ctrl.Focus();
        //        return false;
        //    }
        //    return true;
        //}

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

        public static bool IsPresentRich(RichTextBox textbox)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show("Error: " + textbox.Name + " is a required field!");
                textbox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsPresentDtp(DateTimePicker dtp)
        {
            if (dtp.Text == "")
            {
                MessageBox.Show("Error: " + dtp.Name + " is a required field!");
                dtp.Focus();
                return false;
            }
            return true;
        }

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

        public static bool NonNegDecimal(TextBox textbox)
        {
            try
            {
                decimal textValue = decimal.Parse(textbox.Text);
                if (textValue >= 0) return true;
                else
                {
                    MessageBox.Show("Error: " + textbox.Name + " must be non-negative value!");
                    textbox.Focus();
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: " + textbox.Name + " must be decimal number!");
                textbox.Focus();
                return false;
            }
        }

        public static bool NonNegInt(TextBox textbox)
        {
            try
            {
                int textValue = int.Parse(textbox.Text);
                if (textValue >= 0) return true;
                else
                {
                    MessageBox.Show("Error: " + textbox.Name + " must be non-negative value!");
                    textbox.Focus();
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: " + textbox.Name + " must be integer number!");
                textbox.Focus();
                return false;
            }
        }
    }
}
