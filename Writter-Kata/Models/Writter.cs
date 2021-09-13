using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Models
{
    class Writter : IWrittable
    {
        public IFormaterable _IFormatereable { get; protected set; }

        public Writter (IFormaterable IFormatereable)
        {
            _IFormatereable = IFormatereable;
        }

        public void Write(string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"File Type: {this._IFormatereable.GetFormat().ToString()}");
            sb.AppendLine($"\tMessage: {message}");

            Console.WriteLine(sb.ToString());
        }
    }
}
