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
    }
}
