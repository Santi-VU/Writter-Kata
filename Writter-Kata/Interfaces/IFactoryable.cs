using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Models;

namespace Writter_Kata.Interfaces
{
    interface IFactoryable
    {
        public IWrittable CreateWritter(TypeFormat typeFormat);
    }
}
