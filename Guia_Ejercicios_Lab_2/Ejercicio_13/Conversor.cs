using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    public class Conversor
    {

        /*Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
            string DecimalBinario(double). Convierte un número de entero a binario.
            double BinarioDecimal(string). Convierte un número binario a entero.*/

        public static string DecimalBinario(int numeroDecimal)
        {
            string numeroBinario = String.Empty;

            do
            {
                numeroBinario = numeroBinario + (numeroDecimal % 2);
                numeroDecimal = numeroDecimal / 2;
                if (numeroDecimal < 2) numeroBinario = numeroBinario + numeroDecimal;

            } while (numeroDecimal > 1);

            char[] charArray = numeroBinario.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }

        public static int BinarioDecimal(string numeroBinario)
        {
            double numero = 0;
            int largoArrayBinario = numeroBinario.Length;

            for (int i = 0; i < largoArrayBinario; i++)
            {
                numero += double.Parse(numeroBinario[i].ToString()) * Math.Pow(2, largoArrayBinario - i - 1);
            }

            return (int)numero;
        }
    }
}
