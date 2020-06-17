using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo 
    {
        public List<T> equipos;
        public string nombre;

        public Torneo()
        {
            this.equipos = new List<T>();
        }

        public Torneo(string nombre) : this()
        {
            this.nombre = nombre;
        } 
        
        public static bool operator ==(Torneo<T> t , T e)
        {
            foreach(Equipo eq in t.equipos)
            {
                if (eq == e) return true;
            }

            return false;
        }
        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }

        public static Torneo<T> operator +(Torneo<T> t, T e)
        {
            if(t == e)
            {
                return t;
            }
            t.equipos.Add((T)e);
            return t;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre del Torneo {0}\n",this.nombre);
            foreach(Equipo e in this.equipos)
            {
                sb.AppendLine(e.Ficha());
            }
            return sb.ToString();
        }

        private string CalcularPartido(T eq1, T eq2)
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("[{0}][{1}]", eq1.Nombre, random.Next(1,10));
            Thread.Sleep(500);
            sb.AppendFormat("[{0}][{1}]", random.Next(1, 10), eq2.Nombre);

            return sb.ToString();
        }

        public string JugarPartido
        {
            get
            {
                Random random = new Random();
                T equipo1 = this.equipos.ElementAt(random.Next(0, this.equipos.Count));
                Thread.Sleep(500);
                T equipo2 = this.equipos.ElementAt(random.Next(0, this.equipos.Count));

                return this.CalcularPartido(equipo1, equipo2);
            }
        }
    }
}
