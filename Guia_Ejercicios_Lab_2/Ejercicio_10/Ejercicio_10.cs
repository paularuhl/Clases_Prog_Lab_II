using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {
            /*Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla
            una pirámide como la siguiente:
                *
               ***
              *****
             *******
            ********* */
            Console.Title = "Ejercicio Nro 10";

            bool ok = true;
            int altura;
            string asteriscos = "*";
            string espacios = string.Empty;
            int cantidadEspacios;

            do
            {
                Console.Write("Ingrese un numero para dar altura a la piramide: ");
                ok = int.TryParse(Console.ReadLine(), out altura);
            } while (!ok);

            cantidadEspacios = altura;
            for (int i = 0; i < altura; i++)
            {
                for(int j = 1; j < cantidadEspacios; j++)
                {
                    espacios = espacios + " ";
                }
                if (i == 0) Console.WriteLine(espacios + asteriscos);
                else
                {
                    asteriscos = asteriscos + "**";
                    Console.WriteLine(espacios + asteriscos);
                }
                cantidadEspacios--;
                espacios = string.Empty;
            }

            Console.ReadKey();
        }
    }
}
