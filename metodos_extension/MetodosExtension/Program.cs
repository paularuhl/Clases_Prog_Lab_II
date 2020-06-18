using Entidades;
using System;
using static Entidades.MetodosExtension;

namespace MetodosExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronica(Estaciones.Invierno));
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronica(Estaciones.Primavera));
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronica(Estaciones.Verano));
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronica(Estaciones.Otonio));

            Console.ReadKey();
        }
    }
}
