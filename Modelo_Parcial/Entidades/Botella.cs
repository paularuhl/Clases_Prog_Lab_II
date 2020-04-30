using System;
using System.Text;

namespace Entidades
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        public int CapacidadLitros
        {
            get
            {
                return this.capacidadML / 1000;
            }
        }
        public int Contenido { 
            get 
            { 
                return this.contenidoML; 
            } 
            set 
            {
                this.contenidoML = value;
            } 
        }
        public float PorcentajeContenido
        {
            get
            {
                return ((this.Contenido / 1000) * 100) / CapacidadLitros;
            }
        }

        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            if (capacidadML < contenidoML) Contenido = capacidadML;
            else Contenido = contenidoML;

            this.capacidadML = capacidadML;
            this.marca = marca;
        }

        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Marca: {0} | Contenido: {1}ml | Capacidad: {2}l |", this.marca, this.Contenido, this.CapacidadLitros);
            return sb.ToString();
        }

        public abstract int ServirMedida();

        public override string ToString()
        {
            return this.GenerarInforme();
        }

        public enum Tipo
        {
            Plastico,
            Vidrio
        }

    }
}
