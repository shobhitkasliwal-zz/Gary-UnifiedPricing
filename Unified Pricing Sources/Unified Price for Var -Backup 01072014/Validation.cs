using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace   Unified_Price_for_Var
{
    public class Validation
    {
        private static string title = "Entry Error";

        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        //======================this statement is checking if field is empty================================
        
        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a requered entry.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }
        //=======================   Must be DECIMAL number   =================================
        
        public static bool IsDecimal(TextBox textBox)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be a decimal number.", Title);
                textBox.Focus();
                return false;
            }
        }

//==================  Must be an INTEGER 32  ======================
        public static bool IsInt32(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }
 //==================  Must be an INTEGER 16  ======================
        public static bool IsInt16(TextBox textBox)
        {
            try
            {
                Convert.ToInt16(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }
//=======================   Value must be in BETWEEN values    ================
        public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min
                    + " and " + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

//=========================   Must be valid PHONE NUMBER   ===============
         public static bool IsValidPhoneNumber(TextBox textBox)
        {
            Regex matchRegex = new Regex(@"\d{3}-\d{3}-\d{4}$");
            MatchCollection matches = matchRegex.Matches(textBox.Text);
            
            if (matches.Count == 0)
            {
                MessageBox.Show("Wrong phone number format."); //In Windows Form
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
         //=======================   Must be valid EMAIL ADDRESS   ==================================
       
         public static bool IsValidEmail(TextBox textBox)
         {
             if (textBox.Text == "")
             {
                 return true;
             }
             else
             {
                 Regex matchRegex = new Regex(@"[a-zA-Z0-9_\-\.]+@[a-zA-Z0-9_\-\.]+\.[a-zA-Z]{2,5}");
                 MatchCollection matches = matchRegex.Matches(textBox.Text);

                 if (matches.Count == 0)
                 {
                     MessageBox.Show("Wrong email address format."); //In Windows Form
                     textBox.Focus();
                     return false;
                 }
                 else
                 {
                     return true;
                 }
                                 
             }
        }

//==================================================



    }
}
