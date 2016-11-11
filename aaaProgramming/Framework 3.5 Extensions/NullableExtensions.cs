using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameworkExtensions
{
    /// <summary>
    /// Extension Methods for the System.Nullable Type
    /// </summary>
    public static partial class NullableExtensions
    {
        /// <summary>
        /// Check if input object is null or has no value.
        /// </summary>
        /// <typeparam name="T">Any .Net Framework struct Type : int, long, decimal, bool, etc... </typeparam>
        /// <param name="input">Input object to be checked. Input object must be a struct</param>
        /// <returns>Returns true if input parameter is null or has no value.</returns>
        /// <remarks>This method applies to all nullable value types like  int?, bool?, decimal?, etc...
        /// </remarks>
        /// <example>
        ///     <code language="C#" title="How to check if you can safely retrieve the value of a nullable value type">
        ///         decimal? price = myBusinessLayer.GetPrice();
        ///         if ( price.IsNullOrHasNoValue() )
        ///         {
        ///             //price is not set in the data layer
        ///             //give it a default value
        ///             price = 0;
        ///         }
        ///     </code>
        /// </example>
        public static bool IsNullOrHasNoValue<T>(this T? input) where T : struct
        {
            if (input == null)
            {
                return true;
            }

            if (input.HasValue == false)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Try get the value of a nullable object.
        /// </summary>
        /// <typeparam name="T">Any .Net Framework struct Type : int, long, decimal, bool, etc... </typeparam>
        /// <param name="input">Input object from which to extract the value.</param>
        /// <param name="defaultValue">The value that will be sent back if input is null or has no value.</param>
        /// <returns>Returns the value of the input object, if input object is not null and has value. Otherwise returns <paramref name="defaultValue"/> </returns>
        /// <remarks>This method applies to all nullable value types like  int?, bool?, decimal?, etc...
        /// </remarks>
        /// <example>
        ///     <code language="C#" title="How to safely retrieve the value of a nullable value type">
        ///         decimal price = myBusinessLayer
        ///                             .GetPrice() // returns a decimal? that may be null
        ///                             .ToValueOrDefault(0);
        ///         
        ///     </code>
        /// </example>
        public static T ToValueOrDefault<T>(this T? input, T defaultValue) where T:struct
        {
            if (input.IsNullOrHasNoValue())
            {
                return defaultValue;
            }

            return input.Value;
        }
    }
}
