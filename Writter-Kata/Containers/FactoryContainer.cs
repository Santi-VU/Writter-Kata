using System;
using System.Collections.Generic;
using System.Text;
using Writter_Kata.Interfaces;
using Writter_Kata.Models;
using Writter_Kata.Models.Factorys;
using Writter_Kata.Models.Formaters;

namespace Writter_Kata.Containers
{
    class FactoryContainer
    {
        private static readonly Dictionary<TypeFormat, IWrittable> createWritters = new Dictionary<TypeFormat, IWrittable>
            {
                { TypeFormat.json, new Writter(new JsonFormater()) },
                { TypeFormat.xml, new Writter(new XmlFormater()) },
                { TypeFormat.yml, new Writter(new YmlFormater()) },
                { TypeFormat.txt, new Writter(new TxtFormater()) }
            };

        private static readonly Dictionary<TypeFormat, IWrittable> createWrittersCloud = new Dictionary<TypeFormat, IWrittable>
            {
                { TypeFormat.json, new WritterCloud(new JsonFormater()) },
                { TypeFormat.xml, new WritterCloud(new XmlFormater()) },
                { TypeFormat.yml, new WritterCloud(new YmlFormater()) },
                { TypeFormat.txt, new WritterCloud(new TxtFormater()) }
            };

        public WritterFactory GetWritterFactory()
        {
            return new WritterFactory(createWritters);
        }

        public CloudFactory GetWritterCloud()
        {
            return new CloudFactory(createWrittersCloud);
        }
    }

}
