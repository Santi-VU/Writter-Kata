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

            while (true) { 
                Console.WriteLine("Type of result: 'File' or 'Cloud'");
                tipo = Console.ReadLine();
                while (tipo != "File" && tipo != "Cloud")
                {
                    Console.WriteLine("Incorrect option... Try again.");
                    tipo = Console.ReadLine();
                }

                Console.WriteLine("Introduzca formato de salida de archivo...(json/xml/yml/txt)");
                opcion = Console.ReadLine();
                String.Equals(opcion, "json", StringComparison.OrdinalIgnoreCase);
                if (String.Equals(opcion, "json", StringComparison.OrdinalIgnoreCase))
                {
                    if (tipo == "File")
                        writter = writterFactory.CreateWritter(TypeFormat.json);
                    else
                        writter = cloudFactory.CreateWritter(TypeFormat.json);
                } 
                else if (String.Equals(opcion, "xml", StringComparison.OrdinalIgnoreCase))
                {
                    if (tipo == "File")
                        writter = writterFactory.CreateWritter(TypeFormat.xml);
                    else
                        writter = cloudFactory.CreateWritter(TypeFormat.xml);
                } 
                else if (String.Equals(opcion, "yml", StringComparison.OrdinalIgnoreCase))
                {
                    if (tipo == "File")
                        writter = writterFactory.CreateWritter(TypeFormat.yml);
                    else
                        writter = cloudFactory.CreateWritter(TypeFormat.yml);
                } 
                else if (String.Equals(opcion, "txt", StringComparison.OrdinalIgnoreCase))
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

                try
                {
                    writter.Write(vehiculo.ToString());
                    tipo = "";
                    opcion = "";
                } catch (Exception ex)
                {
                    Console.WriteLine("Hubo un error...");
                }             
            }
        }
    }
}
