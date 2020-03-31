using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            /* 1.Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la    
             siguiente firma: bool Validar(int valor, int min, int max):
             a.valor: dato a validar
             b.min y max: rango en el cual deberá estar la variable valor.
             Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
             anteriormente que esten dentro del rango - 100 y 100.
             Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
             Nota: Utilizar variables escalares, NO utilizar vectores*/
            Console.Title = "Ejercicio Nro 11";

            int numero;
            int max = int.MinValue;
            int min = int.MaxValue;
            int acumulador = 0;
            int i;
            bool esNumero = true;
            bool dentroDelRango = true;

            for (i = 0; i < 10; i++)
            {
                do
                {
                    if (!esNumero || !dentroDelRango)
                        Console.WriteLine("Error! Ingreso Invalido.");

                    Console.Write("Ingrese un numero: ");
                    esNumero = int.TryParse(Console.ReadLine(), out numero);
                    dentroDelRango = Validacion.Validar(numero, -100, 100);

                    if (esNumero && dentroDelRango)
                    {
                        if(i == 0)
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
                    }

                } while (!esNumero || !dentroDelRango);
            }

            float promedio = acumulador / (float)i;
            Console.WriteLine("Maximo: {0} \nMinimo: {1} \nPromedio: {2:#,###.00}", max, min, promedio);
            Console.ReadKey();
        }
    }
}
