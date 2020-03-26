using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            /* Ingresar 5 números por consola, guardándolos en una variable escalar.
             * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio. */
            Console.Title = "Ejercicio Nro 01";

            int numero;
            int max = 0;
            int min = 0;
            int acumulador = 0;
            int i;
            bool esNumero = false;

            for (i = 0; i < 5; i++)
            {
                bool primeraVezPreguntada = true;

                do
                {
                    if (!primeraVezPreguntada && !esNumero)
                        Console.WriteLine("Error! Eso no es un numero.");

                    Console.Write("Ingrese un numero: ");
                    esNumero = int.TryParse(Console.ReadLine(), out numero);
                    if (esNumero)
                    {
                        if (i == 0)
                        {
                            max = numero;
                            min = numero;
                        }
                        if (numero > max)
                        {
                            max = numero;
                        }
                        else if (numero < min)
                        {
                            min = numero;
                        }
                        acumulador += numero;
                        primeraVezPreguntada = true;
                    }
                    else primeraVezPreguntada = false;

                } while (!esNumero);
            }
            float promedio = acumulador / (float)i;
            Console.WriteLine("Maximo: {0} \nMinimo: {1} \nPromedio: {2:#,###.00}", max, min, promedio);
            Console.ReadKey();
        }
    }
}
