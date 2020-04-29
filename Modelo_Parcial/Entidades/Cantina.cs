using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;

        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }

        private Cantina(int espacios)
        {
            this.botellas = new List<Botella>();
        }

        public static Cantina GetCantina(int espacios)
        {
            if(singleton is null)
            {
                singleton = new Cantina(espacios);
            } 
            else
            {
                singleton.espaciosTotales = espacios;
            }
            return singleton;
        }

        public static bool operator + (Cantina c, Botella b)
        {
            if(c.Botellas.Count < c.espaciosTotales)
            {
                c.Botellas.Add(b);
                return true;
            }
            return false;
        }
    }
}
