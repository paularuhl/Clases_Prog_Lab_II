using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Ejercicio_15
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 15";
            double numeroUno = PedirNumero("Ingrese el primer número: ");
            double numeroDos = PedirNumero("Ingrese el segundo número: ");
            Console.Write("Ingrese el operador a utilizar: ");
            string operador = Console.ReadKey().KeyChar.ToString();

            Console.WriteLine("\nEl resultado es: {0}", Calculadora.Calcular(numeroUno, numeroDos, operador));
            Console.ReadKey();
        }

        static double PedirNumero(string mensaje)
        {
            bool esNumero = true;
            double numero;
            Console.Write(mensaje);
            do
            {
                if (!esNumero)
                    Console.Write("Error! Eso no es un numero. Reingresar: ");

                esNumero = double.TryParse(Console.ReadLine(), out numero);

            } while (!esNumero);

            return numero;
        }
    }
}
