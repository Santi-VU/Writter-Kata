using System;
using System.Collections.Generic;
using Writter_Kata.Containers;
using Writter_Kata.Interfaces;
using Writter_Kata.Models;
using Writter_Kata.Models.Factorys;
using Writter_Kata.Models.Formaters;

namespace Writter_Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryContainer container = new FactoryContainer();
            WritterFactory writterFactory = container.GetWritterFactory();
            CloudFactory cloudFactory = container.GetWritterCloud();
            IWrittable writter = null;
            ///
            string tipo = "";
            string opcion = "";
            Vehicle vehiculo = new Vehicle(Models.VehicleType.Coche, "KIA", "Río");
            ///
            Console.WriteLine("Type of result: 'File' or 'Cloud'");
            tipo = Console.ReadLine();

            if (tipo == "File")
            {
                
            } else if (tipo == "Cloud")
            {

            } else
            {
                Console.WriteLine("Incorrect option... Try again.");
            }

            Console.WriteLine("Introduzca formato de salida de archivo...(json/xml/yml/txt)");
            opcion = Console.ReadLine();

            if (opcion == "json")
            {
                if (tipo == "File")
                    writter = writterFactory.CreateWritter(TypeFormat.json);
                else
                    writter = cloudFactory.CreateWritter(TypeFormat.json);
            } 
            else if (opcion == "xml")
            {
                if (tipo == "File")
                    writter = writterFactory.CreateWritter(TypeFormat.xml);
                else
                    writter = cloudFactory.CreateWritter(TypeFormat.xml);
            } 
            else if (opcion == "yml")
            {
                if (tipo == "File")
                    writter = writterFactory.CreateWritter(TypeFormat.yml);
                else
                    writter = cloudFactory.CreateWritter(TypeFormat.yml);
            } 
            else if (opcion == "txt")
            {
                if (tipo == "File")
                    writter = writterFactory.CreateWritter(TypeFormat.txt);
                else
                    writter = cloudFactory.CreateWritter(TypeFormat.txt);
            } 
            else
            {
                Console.WriteLine("Opción incorrecta... Saliendo!");
            }

            writter.Write(vehiculo.ToString());
        }
    }
}
