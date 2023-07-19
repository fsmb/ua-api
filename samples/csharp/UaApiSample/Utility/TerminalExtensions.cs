/*
 * Copyright © 2019 Federation of State Medical Boards
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

namespace Fsmb.Apis.UA
{
    /// <summary>Provides extensions for <see cref="ITerminal"/>.</summary>
    public static class TerminalExtensions
    {
        /// <summary>Reads a date.</summary>
        /// <param name="terminal">Terminal</param>
        /// <param name="prompt">Read prompt.</param>
        /// <param name="minDate">Minimum date to accept.</param>
        /// <param name="maxDate">Maximum date to accept.</param>
        /// <param name="allowEmpty"><see langword="true"/> to allow empty dates.</param>
        /// <returns>The date/time, if any.</returns>
        public static DateTime? ReadDate ( this ITerminal terminal, string prompt = null, DateTime? minDate = null, DateTime? maxDate = null, bool allowEmpty = false )
        {
            if (!String.IsNullOrEmpty(prompt))
                terminal.Write(prompt);

            do
            {
                var input = terminal.ReadLine().Trim();
                if (allowEmpty && String.IsNullOrEmpty(input))
                    return null;

                if (DateTime.TryParse(input, out var result))
                {
                    if (minDate.HasValue && result < minDate.Value || maxDate.HasValue && result > maxDate.Value)
                    {
                        var min = minDate.GetValueOrDefault().ToString("MM/dd/yyyy");
                        var max = maxDate.GetValueOrDefault().ToString("MM/dd/yyyy");

                        if (minDate.HasValue && maxDate.HasValue)
                            terminal.WriteError($"Value must be between {min} and {max}");
                        else if (minDate.HasValue)
                            terminal.WriteError($"Value must be >= {min}");
                        else
                            terminal.WriteError($"Value must be <= {max}");

                        continue;
                    };

                    return result;
                } else
                    terminal.WriteError("Invalid date");                
            } while (true);
        }

        /// <summary>Reads an Int32.</summary>
        /// <param name="terminal">Terminal</param>
        /// <param name="prompt">Read prompt.</param>
        /// <param name="minValue">Minimum value to accept.</param>
        /// <param name="maxValue">Maximum value to accept.</param>
        /// <param name="allowEmpty"><see langword="true"/> to allow empty values.</param>
        /// <returns>The value, if any.</returns>
        public static int? ReadInt32 ( this ITerminal terminal, string prompt = null, int? minValue = null, int? maxValue = null, bool allowEmpty = false )
        {
            if (!String.IsNullOrEmpty(prompt))
                terminal.Write(prompt);

            do
            {
                var input = terminal.ReadLine().Trim();
                if (allowEmpty && String.IsNullOrEmpty(input))
                    return null;

                if (Int32.TryParse(input, out var result))
                {
                    if (minValue.HasValue && result < minValue.Value || maxValue.HasValue && result > maxValue.Value)
                    {
                        var min = minValue.GetValueOrDefault();
                        var max = maxValue.GetValueOrDefault();

                        if (minValue.HasValue && maxValue.HasValue)
                            terminal.WriteError($"Value must be between {min} and {max}");
                        else if (minValue.HasValue)
                            terminal.WriteError($"Value must be >= {min}");
                        else
                            terminal.WriteError($"Value must be <= {max}");

                        continue;
                    };

                    return result;
                } else
                    terminal.WriteError("Invalid number");
            } while (true);
        }

        /// <summary>Reads a string.</summary>
        /// <param name="terminal">Terminal</param>
        /// <param name="prompt">Read prompt.</param>
        /// <param name="allowEmptyString"><see langword="true"/> to allow empty values.</param>
        /// <returns>The value.</returns>
        public static string ReadString ( this ITerminal terminal, string prompt = null, bool allowEmptyStrings = true )
        {
            if (!String.IsNullOrEmpty(prompt))
                terminal.Write(prompt);

            do
            {
                var input = terminal.ReadLine().Trim();
                if (!String.IsNullOrEmpty(input) || allowEmptyStrings)
                    return input;

                terminal.WriteError("Input is required");
            } while (true);
        }

        /// <summary>Writes a debug message.</summary>
        /// <param name="terminal">Terminal.</param>
        /// <param name="message">Message.</param>
        public static void WriteDebug ( this ITerminal terminal, string message ) => terminal.WriteLine(message, foreColor: ConsoleColor.Cyan);

        /// <summary>Writes an error message.</summary>
        /// <param name="terminal">Terminal.</param>
        /// <param name="message">Message.</param>
        public static void WriteError ( this ITerminal terminal, string message ) => terminal.WriteLine(message, foreColor: ConsoleColor.Red);

        /// <summary>Writes an empty line.</summary>
        /// <param name="terminal">Terminal.</param>
        public static void WriteLine ( this ITerminal terminal ) => terminal.WriteLine("");

        /// <summary>Writes a message using the specified colors.</summary>
        /// <param name="terminal">Terminal.</param>
        /// <param name="message">Message.</param>
        /// <param name="foreColor">The foreground color.</param>
        /// <param name="backColor">The background color.</param>
        public static void WriteLine ( this ITerminal terminal, string message, ConsoleColor? foreColor = null, ConsoleColor? backColor = null )
        {
            var originalForeColor = terminal.ForegroundColor;            
            var originalBackColor = terminal.BackgroundColor;

            try
            {
                if (foreColor.HasValue)
                    terminal.ForegroundColor = foreColor.Value;
                if (backColor.HasValue)
                    terminal.BackgroundColor = backColor.Value;

                terminal.WriteLine(message);
            } finally
            {
                if (foreColor.HasValue)
                    terminal.ForegroundColor = originalForeColor;
                if (backColor.HasValue)
                    terminal.BackgroundColor = originalBackColor;
            };
        }

        /// <summary>Writes a warning message.</summary>
        /// <param name="terminal">Terminal.</param>
        /// <param name="message">Message.</param>
        public static void WriteWarning ( this ITerminal terminal, string message ) => terminal.WriteLine(message, foreColor: ConsoleColor.DarkYellow);

        /// <summary>Writes an object.</summary>
        /// <param name="terminal">Terminal.</param>
        /// <param name="value">Value to write.</param>
        public static void WriteObject<T> ( this ITerminal terminal, string label, T value, ObjectWriterOptions options = default )
        {
            var writer = new ObjectWriter(terminal, options);
            writer.WriteObject(label, value);
        }
    }
}
