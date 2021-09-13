using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Models
{
    class WritterFactory : IFactoryable
    {
        public Dictionary<TypeFormat, IWrittable> _writterCreator;

        public WritterFactory(Dictionary<TypeFormat, IWrittable> writterCreator)
        {
            _writterCreator = writterCreator;
        }

        public IWrittable CreateWritter(TypeFormat typeFormat)
        {
            return _writterCreator[typeFormat];
        }
    }
}
