﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return d.GetCantidad() != ((Dolar)e).GetCantidad();
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return d.GetCantidad() != ((Dolar)p).GetCantidad();
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() != d2.GetCantidad();

        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return !(d != e);
        }
        public static bool operator ==(Dolar d, Pesos p)
        {
            return !(d != p);
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return !(d1 != d2);
        }
    }
}
