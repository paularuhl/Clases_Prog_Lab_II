using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            /* Mostrar por pantalla todos los números primos que haya 
            * hasta el número que ingrese el usuario por consola.*/
            Console.Title = "Ejercicio Nro 03";

            int numero;
            int contador = 0;
            bool esNumero = false;

            do
            {
                Console.Write("Ingrese un numero: ");
                esNumero = int.TryParse(Console.ReadLine(), out numero);
            } while (!esNumero);

            for (int i = 2; i <= numero; i++)
            {
                contador = 0;
                for (int j = i; j > 0; j--)
                {
                    if (i % j == 0)
                    {
                        contador++;
                    }
                }
                if (contador == 2)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.ReadKey();
        }
    }
}
