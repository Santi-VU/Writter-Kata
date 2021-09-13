using System;
using System.Collections.Generic;
using Writter_Kata.Interfaces;
using Writter_Kata.Models;
using Writter_Kata.Models.Formaters;

namespace Writter_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<TypeFormat, IWrittable> createWritters = new Dictionary<TypeFormat, IWrittable>
            {
                { TypeFormat.json, new Writter(new JsonFormater()) },
                { TypeFormat.xml, new Writter(new XmlFormater()) },
                { TypeFormat.yml, new Writter(new YmlFormater()) },
                { TypeFormat.txt, new Writter(new TxtFormater()) }
            };
            WritterFactory writterFactory = new WritterFactory(createWritters);
            IWrittable writter = null;
            ///
            string opcion = "";
            Vehicle vehiculo = new Vehicle(Models.VehicleType.Coche, "KIA", "Río");
            ///

            Console.WriteLine("Introduzca formato de salida de archivo...(json/xml/yml/txt)");
            opcion = Console.ReadLine();

            if (opcion == "json")
            {
                writter = writterFactory.CreateWritter(TypeFormat.json);
            } 
            else if (opcion == "xml")
            {
                writter = writterFactory.CreateWritter(TypeFormat.xml);
            } 
            else if (opcion == "yml")
            {
                writter = writterFactory.CreateWritter(TypeFormat.yml);
            } 
            else if (opcion == "txt")
            {
                writter = writterFactory.CreateWritter(TypeFormat.txt);
            } 
            else
            {
                Console.WriteLine("Opción incorrecta... Saliendo!");
            }

            writter.Write(vehiculo.ToString());
        }
    }
}
