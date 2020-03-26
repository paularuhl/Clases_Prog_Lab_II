using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Ejercicio_05
    {
        static void Main(string[] args)
        {
            /* Un centro numérico es un número que separa una lista de números enteros(comenzando en 1)
             * en dos grupos de números, cuyas sumas son iguales. El primer centro numérico es el 6,
             * el cual separa la lista(1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8) cuyas sumas son
             * ambas iguales a 15.El segundo centro numérico es el 35, el cual separa la lista(1 a 49)
             * en los grupos: (1 a 34) y(36 a 49) cuyas sumas son ambas iguales a 595. Se pide elaborar 
             * una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola. */
            Console.Title = "Ejercicio Nro 05";

            int numero;
            bool esNumero;
            do
            {
                Console.Write("Ingrese un numero: ");
                esNumero = int.TryParse(Console.ReadLine(), out numero);
            } while (!esNumero);

            int grupoUno = 0;
            int grupoDos = 0;

            for (int i = 1; i < numero; i++)
            {
                //acumulo numeritos hasta el original, creando la primera parte de la "lista"
                grupoUno += i;

                for (int j = i + 2; j < numero; j++)
                {
                    //despejo i+1 como centro numerico, y arranco la nueva lista desde i+2.
                    grupoDos += j;

                    //comparo los dos grupos hasta ahora, si son iguales, YAS, we've got a winner!
                    if (grupoUno == grupoDos)
                    {
                        Console.WriteLine("\nCentro numerico {0}.", i + 1);
                        Console.WriteLine("*Separa la lista 1 a {2}, en 1-{0} y {1}-{2}.", i, i + 2, j);
                        Console.WriteLine("*Da como resultado {0}.", grupoUno);
                    }
                }
                //si no lo son, reinicio el segundo grupo y sigo intentando.
                grupoDos = 0;
            }
            Console.ReadKey();
        }
    }
}
