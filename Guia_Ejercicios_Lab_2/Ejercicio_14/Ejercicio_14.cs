using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Ejercicio_14
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 14";

            double areaCuadrado = CalculoDeArea.CalcularCuadrado(PedirNumero("Ingrese el lado de su cuadrado: "));

            double areaTriangulo = CalculoDeArea.CalcularTriangulo(PedirNumero("Ingrese la base de su triangulo: "), PedirNumero("Ingrese la altura de su triangulo: "));

            double areaCirculo = CalculoDeArea.CalcularCirculo(PedirNumero("Ingrese el radio de su circulo: "));

            Console.WriteLine("Area del Cuadrado: {0:0.00}\nArea del Triángulo: {1:0.00}\nArea del Círculo: {2:0.00}", areaCuadrado, areaTriangulo, areaCirculo);
            Console.ReadKey();
        }

        static double PedirNumero(string mensaje)
        {
            bool esNumero = true;
            double numero;
            Console.WriteLine(mensaje);
            do
            {
                if (!esNumero)
                    Console.WriteLine("Error! Eso no es un numero. Reingresar: ");

                esNumero = double.TryParse(Console.ReadLine(), out numero);

            } while (!esNumero);

            return numero;
        }


    }
}
