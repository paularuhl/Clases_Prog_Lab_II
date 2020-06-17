using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} fundado el {1} ", this.nombre, this.fechaCreacion.ToShortDateString());
            return sb.ToString();
        }
    }
}
