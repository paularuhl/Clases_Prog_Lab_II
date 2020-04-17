using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            cotizRespectoDolar = 1.16;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / GetCotizacion());
        }

        public static explicit operator Pesos(Euro e)
        {
            return (Pesos)((Dolar)e);
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return e.GetCantidad() != ((Euro)d).GetCantidad();
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return e.GetCantidad() != ((Euro)p).GetCantidad();
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return e1.GetCantidad() != e2.GetCantidad();
        }

        public static Euro operator +(Euro e1, Euro e2)
        {
            return e1.GetCantidad() + e2.GetCantidad();
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return e.GetCantidad() + ((Euro)d).GetCantidad();
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return e.GetCantidad() + ((Euro)((Dolar)p)).GetCantidad();
        }


        public static Euro operator -(Euro e1, Euro e2)
        {
            return e1.GetCantidad() - e2.GetCantidad();
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return e.GetCantidad() - ((Euro)d).GetCantidad();
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return e.GetCantidad() - ((Euro)((Dolar)p)).GetCantidad();
        }


        public static bool operator ==(Euro e, Dolar d)
        {
            return !(e != d);
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            return !(e != p);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return !(e1 != e2);
        }
    }
}
