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
            string binario = String.Empty;

            do
            {
                binario = binario + (numeroDecimal % 2);
                numeroDecimal = numeroDecimal / 2;
                if (numeroDecimal < 2) binario = binario + numeroDecimal;

            } while (numeroDecimal > 1);

            char[] charArray = binario.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }

        public static int BinarioDecimal(string numeroBinario)
        {
            int[] arrayBinario = new int[numeroBinario.Length];
            string numeroDecimal = "";
            double numero = 0;
            bool flag = true;
            int largoArrayBinario = arrayBinario.Length;
            int i;
            for (i = 0; i < numeroBinario.Length; i++)
            {
                arrayBinario[i] = (int)char.GetNumericValue(numeroBinario[i]);
                if (arrayBinario[i] != 0 && arrayBinario[i] != 1)
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                for (i = 0; i < largoArrayBinario; i++)
                {
                    numero += (arrayBinario[i] * Math.Pow(2, largoArrayBinario - i - 1));
                }
                numeroDecimal = numero.ToString();
            }
            else
            {
                numeroDecimal = "Valor invalido";
            }

            return numeroDecimal;
        }
    }
}
