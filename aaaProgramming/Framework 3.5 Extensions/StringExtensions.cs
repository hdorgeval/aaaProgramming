using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameworkExtensions
{
    /// <summary>
    /// Extensions Methods for the System.String type
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
    }
}
