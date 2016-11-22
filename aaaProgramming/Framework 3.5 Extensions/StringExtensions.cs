using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FrameworkExtensions
{
    /// <summary>
    /// Extension Methods for the System.String type
    /// </summary>
    public static partial class StringExtensions
    {
        /// <summary>
        /// Check if input string is null or empty.
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>Returns true if the input string is null or empty.</returns>
        public static bool IsNullOrEmpty(this string input)
        {
            if (System.String.IsNullOrEmpty(input))
            {
                return true;
            }
            
            return false;
        }

        /// <summary>
        /// Check if input string is not null and not empty.
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>Returns true if the input string is not null and not empty.</returns>
        public static bool IsNotNullOrEmpty(this string input)
        {
            return input.IsNullOrEmpty() == false;
        }

        /// <summary>
        /// Check if input string is either null or empty of consists only of white-space characters.
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>Returns true if the input string is null or empty or has only white-spaces characters.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
        public static bool IsNullOrEmptyOrWhiteSpace(this string input)
        {
            if (input.IsNullOrEmpty())
            {
                return true;
            }

            input = input.Replace(" ", string.Empty);
            if (input.IsNullOrEmpty())
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Check if input string is not null and not empty and does not consist only of white-space characters.
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>Returns true if the input string is not null and not empty and does not consist only of white-space characters.</returns>
        public static bool IsNotNullOrEmptyOrWhiteSpace(this string input)
        {
            return input.IsNullOrEmptyOrWhiteSpace() == false;
        }

        /// <summary>
        /// If input string is null, this method returns <paramref name="defaultValue"/> parameter.
        /// If input string is not null, this method returns the input string.
        /// This method is usefull when the input string comes from a data store like SQL 
        /// and is used to initialize the content of a field in the UI.
        /// </summary>
        /// <param name="input">Input string. This string can be null.</param>
        /// <param name="defaultValue">The string that will be sent back if input string is null.</param>
        /// <returns>Returns input string if input is not null,otherwise returns defaultValue</returns>
        public static string ToStringOrDefault(this string input, string defaultValue)
        {
            if (input == null)
            {
                return defaultValue;
            }

            return input;
        }


        /// <summary>
        /// Check if input string is equal to another string.
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="value">String to compare</param>
        /// <param name="stringComparison">StringComparison enumeration</param>
        /// <returns>Returns true if both strings are null. 
        /// Returns false if only one of the two string is null.
        /// Returns the result of the call to String.Equals in all other cases.
        /// </returns>
        public static bool IsEqualTo(this string input, string value,StringComparison stringComparison)
        {
            if (input == null && value == null)
            {
                return true;
            }

            if (input == null)
            {
                return false;
            }

            if (value == null)
            {
                return false;
            }

            bool result = input.Equals(value, stringComparison);
            return result;
        }

        /// <summary>
        /// Check if input string is not equal to another string.
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="value">String to compare</param>
        /// <param name="stringComparison">StringComparison enumeration</param>
        /// <returns> Returns true if strings are different
        /// </returns>
        public static bool IsNotEqualTo(this string input, string value, StringComparison stringComparison)
        {
            return input.IsEqualTo(value, stringComparison) == false;
        }

        /// <summary>
        /// Converts a string into a DateTime.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <param name="dateTimeFormat">Standard Date and Time format string.
        /// For a detailed list of possible formats see:https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        /// You can also use prefined values from the class <see cref="StandardDateTimeFormat"/> 
        /// </param>
        /// <param name="culture">String representing a culture.
        /// Example:
        ///         French : "fr-FR";
        ///         US : "en-US".
        /// </param>
        /// <returns>Returns a DateTime object if the conversion has succedeed. Returns null otherwise.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
        public static DateTime? ToDateTimeOrDefault(this string input, string dateTimeFormat, string culture)
        {
            if (input.IsNullOrEmptyOrWhiteSpace())
            {
                return null;
            }

            if (dateTimeFormat.IsNullOrEmptyOrWhiteSpace())
            {
                return null;
            }

            if (culture.IsNullOrEmptyOrWhiteSpace())
            {
                return null;
            }

            var provider = new CultureInfo(culture);

            DateTime result = System.DateTime.Now;
            DateTimeStyles datetimeStyle = DateTimeStyles.None;
            input = input.Trim();

            if (System.DateTime.TryParseExact(input,dateTimeFormat,provider,datetimeStyle,out result))
            {
                return result;
            }

            return null;
        }

        /// <summary>
        /// Remove supplied currency symbol from input string. 
        /// </summary>
        /// <param name="input">Input string that represents a currency number prefixed or postfixed with a currency symbol.</param>
        /// <param name="value">Currency symbol that should be removed from input string</param>
        /// <returns>Returns the input string without any currency symbol.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
        public static string RemoveCurrencySymbol(this string input, string value)
        {
            if (input.IsNullOrEmptyOrWhiteSpace())
            {
                return input;
            }

            if (value.IsNullOrEmptyOrWhiteSpace())
            {
                return input;
            }

            input = input.Replace(value, string.Empty)
                         .Trim();
                        
            return input;
        }


        private static string[] _currencySymbols = new string[] {  "₽", "₺", "₾", "₹", "₮", "$", "$b", "$U", "£", "¥", "￥", "₡", "₩", "₪", "₫", "฿", "€", "B/.", "Bs", "BZ$", "C$", "CHF", "Din.", "Ft", "Gs", "HK$", "J$", "Kč", "kn", "kr", "kr.", "L.", "lei", "Lek", "Ls", "man.", "MOP", "NT$", "Php", "Q", "R", "R$", "RD$", "Rp", "Rs", "S", "S/.", "SFr.", "su'm", "TT$", "Z$", "zł", "грн.", "ден.", "Дин.", "лв", "ман.", "р.", "сом", "сўм", "Т", "դր.", "ج.م.‏", "د.ا.‏", "د.إ.‏", "د.ب.‏", "د.ت.‏", "د.ج.‏", "د.ع.‏", "د.ك.‏", "د.ل.‏", "د.م.‏", "ر.س.‏", "ر.ع.‏", "ر.ق.‏", "ر.ي.‏", "ريال", "ل.س.‏", "ل.ل.‏", "ރ." };

        /// <summary>
        /// Remove currency symbol from input string.
        /// </summary>
        /// <param name="input">Input string that represents a currency number prefixed or postfixed with a currency symbol.</param>
        /// <returns>Returns the input string without its currency symbol.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
        public static string RemoveCurrencySymbol(this string input)
        {
            if (input.IsNullOrEmptyOrWhiteSpace())
            {
                return input;
            }

            foreach (var item in _currencySymbols)
            {
                if (input.Contains(item) )
                {
                    var result = input.RemoveCurrencySymbol(item);
                    return result;
                }
            }

            return input;
        }

        /// <summary>
        /// Converts a string into System.Int32 (int).
        /// </summary>
        /// <param name="input">Input string to be converted to an int.</param>
        /// <returns>Returns an integer System.Int32 if the conversion succeeds. Returns null otherwise.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
        public static int? ToInt32OrDefault(this string input)
        {
            if (input.IsNullOrEmptyOrWhiteSpace())
            {
                return null;
            }

            input = input.Replace(" ", string.Empty);
            input = input.Replace(CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator, string.Empty);
            
            int value = 0;
            if (System.Int32.TryParse(input,out value))
            {
                return value;
            }

            return null;
        }

        /// <summary>
        /// Check if input string is found in the specified list of values.
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="values">List of strings in which to search for the input string</param>
        /// <param name="stringComparison">StringComparison enumeration</param>
        /// <returns>Returns true if the input string has been found in the list of <paramref name="values"/> </returns>
        /// <example>
        /// <code language="C#" title="How to check if user input fits a discrete set of possible values">
        ///     string[] validValues = new string[] { "false", "no", "faux", "non" };
        ///     string userInput = someTextBox.Text;
        ///     if ( userInput.IsIn(validValues,StringComparison.CurrentCultureIgnoreCase))
        ///     {
        ///         //process user input.
        ///     }
        /// </code> 
        /// </example>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1")]
        public static bool IsIn(this string input, IList<string> values,StringComparison stringComparison)
        {

            if (input.IsNullOrEmpty())
            {
                return false;
            }

            if (values.IsNullOrEmpty())
            {
                return false;
            }

            foreach (var item in values)
            {
                if (item.IsEqualTo(input,stringComparison))
                {
                    return true;
                }
            }

            return false;
        }


        private static HashSet<string> trueValues = new HashSet<string>() { "true", "True","TRUE","YES", "Yes", "yes", "y","Y", "vrai","oui", "ok", "OK","1", "o", "O" };
        private static HashSet<string> falseValues = new HashSet<string>() { "false", "False","FALSE", "no", "No","NO", "n","N", "faux", "Faux","Non", "NON", "non", "Ko","KO", "ko", "0"};

        /// <summary>
        /// Convert input string to a boolean.
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>returns a boolean if the conversion has succeeded. returns null otherwise</returns>
        /// <example>
        ///     <code language="C#" title="How to safely convert a string to a boolean">
        ///         bool? result = "true".ToBooleanOrDefault(); //returns true
        ///         bool? result = "ok".ToBooleanOrDefault(); //returns true
        ///         bool? result = "yes".ToBooleanOrDefault(); //returns true
        ///         bool? result = "1".ToBooleanOrDefault(); //returns true
        ///         bool? result = "false".ToBooleanOrDefault(); //returns false
        ///         bool? result = "0".ToBooleanOrDefault(); //returns false
        ///         bool? result = "xyz".ToBooleanOrDefault(); //returns null
        ///     </code>
        /// </example>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
        public static bool? ToBooleanOrDefault(this string input)
        {
            if (input.IsNullOrEmptyOrWhiteSpace())
            {
                return null;
            }

            input = input.Trim();
            if (trueValues.Contains(input))
            {
                return true;
            }

            if (falseValues.Contains(input))
            {
                return false;
            }

            return null;
        }
    }
}
