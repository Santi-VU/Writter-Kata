using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;

namespace Writter_Kata.Models.Factorys
{
    public class CloudFactory : IFactoryable
    {
        private Dictionary<TypeFormat, IWrittable> _cloudCreator;

        public CloudFactory(Dictionary<TypeFormat, IWrittable> cloudCreator)
        {
            _cloudCreator = cloudCreator;
        }

        public IWrittable CreateWritter(TypeFormat typeFormat)
        {
            return _cloudCreator[typeFormat];
        }
    }
}
