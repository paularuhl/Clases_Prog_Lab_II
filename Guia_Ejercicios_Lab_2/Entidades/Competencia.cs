using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            return "";
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            if(c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool success = false;
            if (c.competidores.Count < c.cantidadCompetidores && c != a)
            {
                c.competidores.Add(a);
                success = true;
            }

            return success;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 auto in c.competidores)
            {
                if (a == auto) return true;
            }

            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}
