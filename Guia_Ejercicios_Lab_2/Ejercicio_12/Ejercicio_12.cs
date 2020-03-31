using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Ejercicio_12
    {
        /*Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
        un mensaje "¿Continuar? (S/N)".
        En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
        opciones.
        El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
        cualquier otro valor.*/
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 12";

            int acumulado = 0;
            int numero;
            bool esNumero = true;

            do
            {
                if (!esNumero) Console.WriteLine("Eso no es un numero!");
                Console.Write("\nIngrese un número para sumar: ");
                esNumero = int.TryParse(Console.ReadLine(), out numero);
                if (esNumero) 
                { 
                acumulado += numero;
                Console.Write("¿Continuar? (S/N): ");
                }
            } while (!esNumero || ValidarRespuesta.ValidaS_N(Console.ReadKey().KeyChar));

            Console.WriteLine("\nEl resultado de la suma es: {0}", acumulado);
            Console.ReadKey();
        }
    }
}
