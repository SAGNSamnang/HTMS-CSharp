using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public static class Validator
    {
        public static bool IsPresent(TextBox textBox)
        {
            if(textBox.Text == "")
            {
                MessageBox.Show(
                    textBox.Tag + " is required field", "Entry error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }
        public static bool IsPresent(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show(
                    comboBox.Tag + " is required to select item first",
                    "Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox.Focus();
                return false;
            }
            return true;
        }
        public static bool IsInt32(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch(Exception)
            {
                MessageBox.Show(textBox.Tag + " must be an integer number", "Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
        }
        public static bool IsDecimal(TextBox textBox)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show(textBox.Tag + " must be a decimal number", "Entry Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
        }
        
    }
}
