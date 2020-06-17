using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

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
