using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            //lado al cuadrado xd
            return Math.Pow(2, lado);

        }
        public static double CalcularTriangulo(double baseTriangulo, double altura)
        {
            //base por altura sobre 2
            return (baseTriangulo * altura) / 2;
        }
        public static double CalcularCirculo(double radio)
        {
            //pi por radio al cuadrado
            return Math.Pow(Math.PI * radio, 2);
        }
    }
}
