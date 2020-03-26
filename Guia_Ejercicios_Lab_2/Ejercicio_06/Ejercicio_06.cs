using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {
            /* Escribir un programa que determine si un año es bisiesto.
            Un año es bisiesto si es múltiplo de 4.Los años múltiplos de 100 no son bisiestos, salvo si ellos
            también son múltiplos de 400.Por ejemplo: el año 2000 es bisiesto pero 1900 no.
            Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.*/
            int anioInicio;
            int anioFin;
            bool esNumero;

            do
            {
                Console.Write("Ingrese un año de inicio: ");
                esNumero = int.TryParse(Console.ReadLine(), out anioInicio);
            } while (!esNumero);

            do
            {
                Console.Write("Ingrese un año de fin: ");
                esNumero = int.TryParse(Console.ReadLine(), out anioFin);
            } while (!esNumero || anioFin < anioInicio);

            for (int i = anioInicio; i < anioFin; i++)
            {
                //si es divisible por 100,
                if (i % 100 == 0)
                {
                    //chequeo que también lo sea por 400, y en ese caso es bisiesto
                    if (i % 400 == 0)
                        Console.WriteLine(i);
                }
                //si no es divisible por 100, pero si por cuatro, entonces es bisiesto
                else if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
