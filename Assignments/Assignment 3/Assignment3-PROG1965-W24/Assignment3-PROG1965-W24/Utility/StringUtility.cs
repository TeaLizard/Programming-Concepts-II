using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment3_PROG1965_W24.Utility
{
    public static class StringUtility
    {
        //
        // Method: ElegantCase
        // Input: A string "s"
        //
        // It should change the string "s", such that
        // each word in "s" starts with an upper-case character, and
        // every other character is in lower-case
        // Any character other than an alphabet remains un-changed
        // For example, if s is "i spent $20 in PRince edward iSLAND on jan 2nd."
        // then it returns; "I Spent $20 In Prince Edward Island On Jan 2nd."
        //
        // You cannot change the access modifier or the return type of the method !! How is this supposed to work with void return type? !!
        // You are ALLOWED to make any necessary changes in parameter(s)
        //
        public static void ElegantCase(ref string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                s = "";
                return;
            }
            s = s.ToLower();

            char[] chars = s.ToCharArray();

            chars[0] = Convert.ToChar(chars[0].ToString().ToUpper());
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ' && i != chars.Length - 1)
                {
                    chars[i + 1] = Convert.ToChar(chars[i + 1].ToString().ToUpper());
                }
            }
            s = new string(chars);
        }
        //
        // Method: FullDateTime
        // Input: A DateTime object date
        // Output: Formated string for date and time
        //
        // It should return the date in
        // the "SS-MM-HH:DD-MM-YYYY" format
        // For example: "58-37-15:19-03-2024"
        // No AM/PM - Military time.
        //
        public static string FullDateTime(DateTime date)
        {
            string longDate = date.ToString("ss-mm-HH:dd-MM-yyyy");
            return longDate;
        }
        //
        // Method: ShortDate
        // Input: A DateTime object date
        // Output: Formated string for date
        //
        // It should return the date in
        // the "DD-MM-YYYY" format (no spaces)
        // For example: "19-03-2024"
        //
        public static string ShortDate(DateTime date)
        {
            string shortDate = date.ToString("dd-MM-yyyy");
            return shortDate;
        }
        //
        // Method: FormatedPhoneNumber
        // Input: String value of a phone number.
        // Output: Formated string for the phone number
        //
        // It should return the phone number 
        // for example, in the "(888)555-6666" format
        //
        public static string FormatedPhoneNumber(string number)
        {
            number = number.Replace("(","").Replace(")", "").Replace("-", "").Replace(" ", "").Replace("Phone:", "").Insert(0, "(").Insert(4, ")").Insert(8, "-");
            return number;
        }
        //
        // Method: FormatedHealthCardNumber
        // Input: String value of a health card number.
        // Output: Formated string for the health card number
        //
        // It should return the health car number 
        // for example, in the "5359-555-666-GD" format
        //
        public static string FormatedHealthCardNumber(string number)
        {
            number = number.Replace("-", "").Replace(" ", "").Insert(4, "-").Insert(8, "-").Insert(12, "-");
            return number;
        }
        //
        // Method: FormatedSIN
        // Input: String value of a social insurance number.
        // Output: Formated string for the social insurance number
        //
        // It should return the social insurance number 
        // for example, in the "535-555-6666" format
        //
        public static string FormatedSIN(string number)
        {
            number = number.Replace("-", "").Replace(" ", "").Insert(3, "-").Insert(7, "-");
            return number;
        }
        //
        // Method: FormatedPostalCode
        // Input: String value of a postal code
        // Output: Formated string for the postal code
        //
        // It should return the postal code
        // for example, in the "L6H 1M8" format
        //
        public static string FormatedPostalCode(string postalCode)
        {
            postalCode = postalCode.Replace("-", "").Replace(" ", "").Insert(3, " ");
            return postalCode;
        }

        public static string GetFullID(int idInput)
        {
            string id = idInput.ToString();
            int idLength = id.Length;
            for (int i = 0; i < (6 - idLength); i++)
            {
                id = $"0{id}";
            }

            return id;
        }
    }
}
