using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Models
{
    class WritterCloud : IWrittable
    {
        public IFormaterable _IFormatereable { get; protected set; }

        public WritterCloud(IFormaterable IFormatereable)
        {
            _IFormatereable = IFormatereable;
        }

        public void Write(string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"File Type (Cloud): {this._IFormatereable.GetFormat().ToString()}");
            sb.AppendLine($"\tMessage: {message}");

            Console.WriteLine(sb.ToString());
        }
    }
}
