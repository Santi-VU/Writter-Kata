﻿using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Models.Formaters
{
    public class XmlFormater : IFormaterable
    {
        public TypeFormat GetFormat()
        {
            return TypeFormat.xml;
        }
    }
}
