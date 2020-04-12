using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_20
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dolar = new Dolar(1);
            var euro = new Euro(1.16);
            var pesos = new Pesos(38.33);

            if(dolar == euro)
            {
                Console.WriteLine("el dolar y euro son iguales");
            }

            if (dolar == pesos)
            {
                Console.WriteLine("el dolar y peso son iguales");
            }

            if (pesos == euro)
            {
                Console.WriteLine("los pesos y euro son iguales");
            }

            Console.ReadKey();
        }
    }
}
