using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public class Calculadora
    {
        public static string Calcular(double numeroUno, double numeroDos, string operador)
        {
            string mensajeRetorno = String.Empty;

            if (Validar(numeroDos)) mensajeRetorno = "No se puede dividir por cero.";
            else
            {
                switch (operador)
                {
                    case "+":
                        mensajeRetorno = (numeroUno + numeroDos).ToString();
                        break;
                    case "-":
                        mensajeRetorno = (numeroUno - numeroDos).ToString();
                        break;
                    case "*":
                        mensajeRetorno = (numeroUno * numeroDos).ToString();
                        break;
                    case "/":
                        mensajeRetorno = (numeroUno / numeroDos).ToString();
                        break;
                    default:
                        mensajeRetorno = "Operador inválido";
                        break;
                }
            }

            return mensajeRetorno;
        }

        private static bool Validar(double numeroDos)
        {
            return numeroDos == 0;
        }
    }
}
