using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Ejercicio_13
    {
        static void Main(string[] args)
        {
            /*Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
            string DecimalBinario(double). Convierte un número de entero a binario.
            double BinarioDecimal(string). Convierte un número binario a entero.*/
            Console.Title = "Ejercicio Nro 13";

            Console.WriteLine(Conversor.DecimalBinario(10));
            Console.ReadKey();

        }
    }
}
