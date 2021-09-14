using System;
using System.Collections.Generic;
using System.Text;

namespace Writter_Kata.Models
{
    public class Vehicle
    {
        public VehicleType type { get; protected set; }
        public string mark { get; protected set; }
        public string model { get; protected set; }

        public Vehicle(VehicleType type, string mark, string model)
        {
            this.type = type;
            this.mark = mark;
            this.model = model;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Vehicle info: ");
            sb.AppendLine($"\t Type: {this.type}, Mark: {this.mark}, Model: {this.model}");

            return sb.ToString();
        }
    }
}
