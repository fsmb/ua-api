/*
 * Copyright © 2023 Federation of State Medical Boards
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
    public class ObjectWriter
    {
        public ObjectWriter(ITerminal terminal, ObjectWriterOptions options)
        {
            _terminal = terminal;
            _options = options;

            _indent = new IndentString(0, _options.IndentTabSize);
        }

        public void WriteObject<T>(string label, T value)
        {
            if (value == null)
            {
                if (_options.ShowNullProperties)
                    WriteProperty(label, "null");

                return;
            };

            //Value types just use ToString
            var type = value.GetType();
            if (type.IsValueType || type == typeof(string))
            {
                WriteProperty(label, value.ToString());
                return;
            };

            //Special case collections
            if (value is System.Collections.IDictionary dict)
                WriteDictionary(label, dict);
            else if (value is System.Collections.IEnumerable items)
                WriteCollection(label, items);
            else
            {
                WriteObjectProperties(label, value);
            };
        }

        private void WriteCollection(string name, System.Collections.IEnumerable items)
        {
            WriteLine($"{name} = [");
            _indent.Indent();

            var count = 0;
            foreach (var item in items)
            {
                WriteObject($"[{count}]", item);
                if (++count > _options.MaxItemsLength)
                    break;
            };

            _indent.Unindent();
            WriteLine("]");
        }

        private void WriteDictionary(string name, System.Collections.IDictionary dict)
        {
            WriteLine($"{name} = [");
            _indent.Indent();

            var count = 0;
            foreach (var key in dict.Keys)
            {
                WriteObject($"[{key.ToString()}]", dict[key]);
                if (++count > _options.MaxItemsLength)
                    break;
            };

            _indent.Unindent();
            WriteLine("]");
        }

        private void WriteObjectProperties<T>(string name, T value)
        {
            WriteLine($"{name} = {{");
            _indent.Indent();

            var properties = value.GetType().GetProperties();
            foreach (var property in properties)
            {
                WriteObject(property.Name, property.GetValue(value));
            };

            _indent.Unindent();
            WriteLine("}");
        }

        private void WriteProperty(string name, string value)
        {
            WriteLine($"{name} = {value}");
        }

        private void WriteLine(string message) => _terminal.WriteLine(_indent + message);

        private readonly ITerminal _terminal;
        private readonly ObjectWriterOptions _options;

        private IndentString _indent;
    }
}
