using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            /* Un número perfecto es un entero positivo, 
            * que es igual a la suma de todos los enteros positivos
            * (excluido el mismo) que son divisores del número.
            * El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            * Escribir una aplicación que encuentre los 4 primeros números perfectos.*/
            Console.Title = "Ejercicio Nro 04";
            int numero = 1;
            int contador = 0;

            do
            {
                int acumulador = 0;

                for (int i = numero - 1; i > 0; i--)
                {
                    if (numero % i == 0)
                    {
                        acumulador += i;
                    }
                }
                if (acumulador == numero)
                {
                    contador++;
                    Console.WriteLine("{0}", numero);
                }
                numero++;
            } while (contador < 4);

            Console.ReadKey();
        }
    }
}
