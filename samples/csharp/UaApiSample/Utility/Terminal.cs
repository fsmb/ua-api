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
    public static class Terminal
    {
        public static DateTime? ReadDate ( string prompt = null, DateTime? minDate = null, DateTime? maxDate = null, bool allowEmpty = false )
        {
            if (!String.IsNullOrEmpty(prompt))
                Console.Write(prompt);

            do
            {
                var input = Console.ReadLine().Trim();
                if (allowEmpty && String.IsNullOrEmpty(input))
                    return null;

                if (DateTime.TryParse(input, out var result))
                {
                    if (minDate.HasValue && result < minDate.Value || maxDate.HasValue && result > maxDate.Value)
                    {
                        var min = minDate.GetValueOrDefault().ToString("MM/dd/yyyy");
                        var max = maxDate.GetValueOrDefault().ToString("MM/dd/yyyy");

                        if (minDate.HasValue && maxDate.HasValue)
                            Terminal.WriteError($"Value must be between {min} and {max}");
                        else if (minDate.HasValue)
                            Terminal.WriteError($"Value must be >= {min}");
                        else
                            Terminal.WriteError($"Value must be <= {max}");

                        continue;
                    };

                    return result;
                } else
                    Terminal.WriteError("Invalid date");                
            } while (true);
        }
        
        public static int? ReadInt32 ( string prompt = null, int? minValue = null, int? maxValue = null, bool allowEmpty = false )
        {
            if (!String.IsNullOrEmpty(prompt))
                Console.Write(prompt);

            do
            {
                var input = Console.ReadLine().Trim();
                if (allowEmpty && String.IsNullOrEmpty(input))
                    return null;

                if (Int32.TryParse(input, out var result))
                {
                    if (minValue.HasValue && result < minValue.Value || maxValue.HasValue && result > maxValue.Value)
                    {
                        var min = minValue.GetValueOrDefault();
                        var max = maxValue.GetValueOrDefault();

                        if (minValue.HasValue && maxValue.HasValue)
                            Terminal.WriteError($"Value must be between {min} and {max}");
                        else if (minValue.HasValue)
                            Terminal.WriteError($"Value must be >= {min}");
                        else
                            Terminal.WriteError($"Value must be <= {max}");

                        continue;
                    };

                    return result;
                } else
                    Terminal.WriteError("Invalid number");
            } while (true);
        }

        public static string ReadString ( string prompt = null, bool allowEmptyStrings = true )
        {
            if (!String.IsNullOrEmpty(prompt))
                Console.Write(prompt);

            do
            {
                var input = Console.ReadLine().Trim();
                if (!String.IsNullOrEmpty(input) || allowEmptyStrings)
                    return input;

                Terminal.WriteError("Input is required");
            } while (true);
        }

        public static void WriteDebug ( string message ) => WriteLine(message, foreColor: ConsoleColor.Cyan);

        public static void WriteError ( string message ) => WriteLine(message, foreColor: ConsoleColor.Red);

        public static void WriteLine () => Console.WriteLine();

        public static void WriteLine ( string message, ConsoleColor? foreColor = null, ConsoleColor? backColor = null )
        {
            if (foreColor.HasValue)
                Console.ForegroundColor = foreColor.Value;
            if (backColor.HasValue)
                Console.BackgroundColor = backColor.Value;

            Console.WriteLine(message);

            if (foreColor.HasValue || backColor.HasValue)
                Console.ResetColor();
        }

        public static void WriteWarning ( string message ) => WriteLine(message, foreColor: ConsoleColor.DarkYellow);
    }
}
