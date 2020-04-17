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
        private static double cotizRespectoDolar;

        static Pesos()
        {
            cotizRespectoDolar = 38.33;
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
            return p.cantidad / GetCotizacion();
        }

        public static explicit operator Euro(Pesos p)
        {
            return (Euro)((Dolar)p);
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
            return new Pesos(d);
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return p.GetCantidad() != ((Pesos)d).GetCantidad();
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return p.GetCantidad() != ((Pesos)e).GetCantidad();

        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return p1.GetCantidad() != p2.GetCantidad();
        }

        public static Pesos operator +(Pesos e1, Pesos e2)
        {
            return e1.GetCantidad() + e2.GetCantidad();
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return p.GetCantidad() + ((Pesos)d).GetCantidad();
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return p.GetCantidad() + ((Pesos)((Dolar)e)).GetCantidad();
        }


        public static Pesos operator -(Pesos e1, Pesos e2)
        {
            return e1.GetCantidad() - e2.GetCantidad();
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return p.GetCantidad() - ((Pesos)d).GetCantidad();
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return p.GetCantidad() - ((Pesos)((Dolar)e)).GetCantidad();
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
