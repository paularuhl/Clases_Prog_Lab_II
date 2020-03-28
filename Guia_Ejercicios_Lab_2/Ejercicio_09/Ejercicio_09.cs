using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Ejercicio_09
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que imprima por pantalla una pirámide como
            la siguiente:
            *
            ***
            *****
            *******
            *********
            El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
            ejemplo anterior la altura ingresada fue de 5.*/
            Console.Title = "Ejercicio Nro 09";

            bool ok = true;
            int altura;
            string asteriscos = "*";

            do
            {
                Console.Write("Ingrese un numero para dar altura a la piramide: ");
                ok = int.TryParse(Console.ReadLine(), out altura);
            } while (!ok);

            for (int i = 0; i < altura; i++)
            {
                if (i == 0) Console.WriteLine(asteriscos);
                else
                {
                    asteriscos = asteriscos + "**";
                    Console.WriteLine(asteriscos);
                }
            }

            Console.ReadKey();
        }
    }
}
