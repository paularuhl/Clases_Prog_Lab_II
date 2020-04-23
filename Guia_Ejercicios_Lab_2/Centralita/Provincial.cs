using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public float CostoLlamada { get; }

        private float CalcularCosto()
        {
            float costo = 0;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = base.Duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    costo = base.Duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    costo = base.Duracion * 0.66f;
                    break;
            }
            return costo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat("CostoLlamada: {0} ", CalcularCosto());
            sb.AppendFormat("Franja Horaria: {0} ", this.franjaHoraria);

            return sb.ToString();
        }

        public Provincial(Franja miFranja, Llamada llamada) 
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) 
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }
}
