﻿using System;
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
        /// Check if input Ilist of T is null or empty.
        /// </summary>
        /// <typeparam name="T">Any .Net Framework Type</typeparam>
        /// <param name="input">Input IList of T</param>
        /// <returns>Returns true if the list is null or empty</returns>
        ///<remarks>
        ///If you need to check that input list is not null and not empty, consider using the <see cref="IsNotNullOrEmpty{T}(IList{T})"/>
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
        /// Check if input Ilist of T is not null an not empty.
        /// </summary>
        /// <typeparam name="T">Any .Net Framework Type</typeparam>
        /// <param name="input">Input IList of T</param>
        /// <returns>Returns true if the list is not null and not empty</returns>
        ///<remarks>
        ///Consider using the positive version <see cref="IsNullOrEmpty{T}(IList{T})"/> instead 
        ///</remarks>
        public static bool IsNotNullOrEmpty<T>(this IList<T> input)
        {
            return input.IsNullOrEmpty() == false;
        }
    }
}
