using System;
using System.Text;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        public abstract float CostoLlamada { get; }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Origen: {0} | Destino: {1} | Duracion: {2}mins |", NroOrigen, NroDestino, Duracion);

            return sb.ToString();
        }
        
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen && l1.Equals(l2);
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion) return 1;
            if (llamada1.Duracion == llamada2.Duracion) return 0;
            return -1;
        }


        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
