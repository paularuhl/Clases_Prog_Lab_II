using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Producto item in e.GetProductos())
            {
                sb.AppendLine(Producto.MostrarProducto(item));
            }

            return sb.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            foreach (Producto item in e.GetProductos())
            {
                if (item is null) continue;
                if (item == p) return true;
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            if(e != p)
            {
                for (int i = 0; i < e.GetProductos().Length; i++)
                {
                    if (e.GetProductos()[i] is null)
                    {
                        e.GetProductos()[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
            {
                for (int i = 0; i < e.GetProductos().Length; i++)
                {
                    if (e.GetProductos()[i] == p)
                    {
                        e.GetProductos()[i] = null;
                    }
                }
            }
            return e;
        }

    }
}
