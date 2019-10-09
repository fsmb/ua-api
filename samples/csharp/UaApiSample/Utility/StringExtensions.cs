/*
 * Copyright © 2018 Federation of State Medical Boards
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
 * documentation files (the “Software”), to deal in the Software without restriction, including without limitation the
 * rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit
 * persons to whom the Software is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
 * COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
using System;
using System.Linq;

namespace Fsmb.Apis.UA
{
    /// <summary>Extension methods for <see cref="String"/>.</summary>
    public static class StringExtensions
    {
        /// <summary>Combines multiple strings together.</summary>
        /// <param name="separator">The separator to use.</param>
        /// <param name="values">The values to combine.</param>
        /// <returns>The combined string.</returns>
        /// <remarks>
        /// The separator is only added between values when they do not already exist. This is useful for building paths.
        /// </remarks>
        public static string Combine ( string separator, params string[] values  )
        {
            //Special case an empty separator
            if (separator.Length == 0)
                return String.Join("", values);

            var bldr = new System.Text.StringBuilder();
            bool endsWithSeparator = true;   //Default to true so we won't add one initially

            foreach (var value in values)
            {
                if (!String.IsNullOrEmpty(value))
                {
                    bool valueHasDelimiter = value.StartsWith(separator);

                    //Add separator as needed
                    if (!endsWithSeparator && !valueHasDelimiter)
                        bldr.Append(separator);
                    else if (endsWithSeparator && valueHasDelimiter && bldr.Length > 0)
                        bldr.Remove(bldr.Length - 1, 1);

                    //Add the next obj
                    bldr.Append(value);

                    endsWithSeparator = value.EndsWith(separator);
                };
            };

            return bldr.ToString();
        }

        /// <summary>Ensure a string ends with a specific value.</summary>
        /// <param name="source">The source.</param>
        /// <param name="value">The value to check.</param>
        /// <returns>The modified value.</returns>
        public static string EnsureEndsWith ( this string source, string value ) => source.EndsWith(value) ? source : source + value;

        /// <summary>Ensure a string starts with a specific value.</summary>
        /// <param name="source">The source.</param>
        /// <param name="value">The value to check.</param>
        /// <returns>The modified value.</returns>
        public static string EnsureStartsWith ( this string source, string value ) => source.StartsWith(value) ? source : value + source;

        /// <summary>Determines if a string starts with any set of values.</summary>
        /// <param name="source">The source.</param>
        /// <param name="values">The values to check.</param>
        /// <returns><see langword="true"/> if it starts with any of them.</returns>
        public static bool StartsWithAny ( this string source, params char[] values ) => values.Any(v => source.StartsWith(v.ToString()));

        /// <summary>Determines if a string starts with any set of values.</summary>
        /// <param name="source">The source.</param>
        /// <param name="values">The values to check.</param>
        /// <returns><see langword="true"/> if it starts with any of them.</returns>
        public static bool StartsWithAny ( this string source, params string[] values ) => values.Any(v => source.StartsWith(v));
    }
}
