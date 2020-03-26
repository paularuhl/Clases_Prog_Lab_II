using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            /* Ingresar un número y mostrar: el cuadrado y el cubo del mismo.
             * Se debe validar que el número sea mayor que cero, 
             * caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".*/
            Console.Title = "Ejercicio Nro 02";
            int numero;
            bool menorQueCero = false;
            bool esNumero = true;
            const string mensajeNoEsNumero = "Eso no es un numero...";
            const string mensajeEsMenorQueCero = "El numero tiene que ser mayor a cero.";

            do
            {
                if (menorQueCero || !esNumero)
                {
                    var mensaje = menorQueCero ? mensajeEsMenorQueCero : mensajeNoEsNumero;
                    Console.WriteLine($"ERROR. {mensaje} ¡Reingresar numero!");
                }
                Console.Write("Ingrese un numero: ");
                    
                esNumero = int.TryParse(Console.ReadLine(), out numero);

                if(esNumero) menorQueCero = numero <= 0;

            } while (menorQueCero || !esNumero);

            double cuadrado = Math.Pow(numero, 2);
            double cubo = Math.Pow(numero, 3);
            Console.WriteLine("Numero: {0:#,###.00} \nCuadrado: {1:#,###.00} \nCubo: {2:#,###.00}", numero, cuadrado, cubo);
            Console.ReadKey();
        }
    }
}
