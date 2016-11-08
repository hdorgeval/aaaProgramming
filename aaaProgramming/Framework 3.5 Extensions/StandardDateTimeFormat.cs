using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameworkExtensions
{
    /// <summary>
    /// System.DateTime format specifiers
    /// </summary>
    public static partial class StandardDateTimeFormat
    {
        /// <summary>
        /// The Short Date ("d") Format Specifier.
        /// Example : 
        ///     05/28/2017 (en-US);
        ///     28/05/2017 (fr-FR).
        /// </summary>
        public static readonly string  ShortDatePattern = "d";


        /// <summary>
        /// The Short Date Time ("g") Format Specifier.
        /// Example : 
        ///     05/28/2017 1:45 PM (en-US);
        ///     28/05/2017 13:45 (fr-FR).
        /// </summary>
        public static readonly string ShortDateShortTimePattern = "g";

        /// <summary>
        /// The Short Date  long Time ("G") Format Specifier.
        /// Example : 
        ///     05/28/2017 1:45:30 PM (en-US);
        ///     28/05/2017 13:45:30 (fr-FR).
        /// </summary>
        public static readonly string ShortDateLongTimePattern = "G";
    }
}
