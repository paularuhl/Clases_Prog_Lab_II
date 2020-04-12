using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar = 1;

        static Pesos()
        {
            cotizRespectoDolar = 1;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Pesos p)
        {

        }

        public static explicit operator Euro(Pesos p)
        {
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Pesos(double d)
        {

        }

        public static bool operator !=(Pesos p, Dolar d)
        {

        }
        public static bool operator !=(Pesos p, Euro e)
        {

        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {

        }



        public static bool operator ==(Pesos p, Dolar d)
        {
            return !(p != d);
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            return !(p != e);
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return !(p1 != p2);
        }
    }
}
