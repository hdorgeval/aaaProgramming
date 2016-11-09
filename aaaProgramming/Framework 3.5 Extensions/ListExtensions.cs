using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameworkExtensions
{
    /// <summary>
    /// Extensions Methods for the IList types
    /// </summary>
    public static partial class ListExtensions
    {
        /// <summary>
        /// Check if input list is null or empty.
        /// </summary>
        /// <typeparam name="T">Any .Net Framework Type</typeparam>
        /// <param name="input">Input list</param>
        /// <returns>Returns true if the list is null or empty</returns>
        ///<remarks>
        ///If you need to check that input list is not null and not empty, consider using the <see cref="IsNotNullOrEmpty"/>
        ///</remarks>
        public static bool IsNullOrEmpty<T>(this IList<T> input)
        {
            if (input == null)
            {
                return true;
            }

            if (input.Count == 0)
            {
                return true;
            }

            return false;
        }


        /// <summary>
        /// Check if input list is not null an not empty.
        /// </summary>
        /// <typeparam name="T">Any .Net Framework Type</typeparam>
        /// <param name="input">Input list</param>
        /// <returns>Returns true if the list is not null and not empty</returns>
        ///<remarks>
        ///Consider using the positive version <see cref="IsNullOrEmpty"/> instead 
        ///</remarks>
        public static bool IsNotNullOrEmpty<T>(this IList<T> input)
        {
            return input.IsNullOrEmpty() == false;
        }


        /// <summary>
        /// Add an item to a list only when this item is not null.
        /// </summary>
        /// <typeparam name="T">Any .Net Framework type.</typeparam>
        /// <param name="input">Input List.</param>
        /// <param name="value">Item to be added to the list. This item will be added if it is not null.</param>
        public static void AddWhenIsNotNull<T>(this IList<T> input, T value)
        {
            if (input == null)
            {
                return;
            }

            if (value == null)
            {
                return;
            }

            input.Add(value);
        }
    }
}
