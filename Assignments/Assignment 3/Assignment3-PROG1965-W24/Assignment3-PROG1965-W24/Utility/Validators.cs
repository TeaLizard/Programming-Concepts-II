using Assignment3_PROG1965_W24.Model.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3_PROG1965_W24.Utility
{
    public static class Validators
    {
        //
        // Method: ValidatePostalCode
        // Input: String value of postal code
        // Output: Exact length string for the postal code
        //
        // It should check for non-alpha-numeric values and remove them
        // It then validates the postal code to be a string of 6 alpha-numeric values
        // It MUSt use Regular Expression for validation
        // If pCode is a valid string then it should return a string
        // of exactly 6 alpha-numeric values. Case of alphabets does not matter.
        // For example, it should return "l6H1m8"
        // If pCode is NOT a valid string
        // then it MUST interact with and warn the user
        //
        public static string ValidatePostalCode(string postalCode)
        {
            postalCode = postalCode.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").ToUpper();

            Regex postalFormat = new Regex(@"^[A-Z]{1}[0-9]{1}[A-Z]{1}[0-9]{1}[A-Z]{1}[0-9]{1}$");

            if (!postalFormat.IsMatch(postalCode))
            {
                MessageBox.Show("Invalid Postal Code");
                return "error";
            }
            return postalCode;
        }
        //
        // Method: ValidatePhoneNumber
        // Input: String value of a phone number
        // Output: Exact length string for the phone number
        //
        // It should check for non-numeric values and remove them
        // It then validates the phoneNumber to be a string of 10 numeric values
        // It MUSt use Regular Expression for validation
        // If phoneNumber is a valid string
        // then it should return a string of exactly 10 numeric values
        // For example, it should return "4165678966"
        // If phoneNumber is NOT a valid string
        // then it MUST interact with and warn the user 
        //
        public static string ValidatePhoneNumber(string number)
        {
            number = number.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Replace("Phone:", "");

            Regex phoneFormat = new Regex(@"^[0-9]{10}$");

            if (!phoneFormat.IsMatch(number))
            {
                MessageBox.Show("Invalid Phone Number");
                return "error";
            }

            return number;
        }
        //
        // Method: ValidateHealthCardNumber
        // Input: String value of a health card number
        // Output: Exact length string for the health card number
        //
        // It should check for non-alpha-numeric values and remove them
        // It then validates the health card number
        // It MUSt use Regular Expression for validation
        // If health card number is a valid string
        // then it should return a string of length 12
        // For example, it should return "8965678966GF"
        // If hcNumber NOT a valid string
        // then it MUST interact with and warn the user
        //
        public static string ValidateHealthCardNumber(string number)
        {
            number = number.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").ToUpper();

            Regex hcNumberFormat = new Regex(@"^[0-9]{10}[A-Z]{2}$");

            if (!hcNumberFormat.IsMatch(number))
            {
                MessageBox.Show("Invalid Health Card Number");
                return "error";
            }

            return number;
        }
        //
        // Method: ValidateSIN
        // Input: String value of a social insurance number
        // Output: Exact length string for the social insurance number
        //
        // It should check for non-numeric values and remove them
        // It then validates the sin to be a string of 9 numeric values
        // It MUSt use Regular Expression for validation
        // If sin is a valid string
        // then it should return a string of exsactly 9 numeric values
        // For example, it should return "535768425"
        // If sin is NOT a valid string
        // then it MUST interact with and warn the user 
        //
        public static string ValidateSIN(string number)
        {
            number = number.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            Regex sinFormat = new Regex(@"^[0-9]{9}$");

            if (!sinFormat.IsMatch(number))
            {
                MessageBox.Show("Invalid Social Insurance Number");
                return "error";
            }

            return number;
        }
    }
}
