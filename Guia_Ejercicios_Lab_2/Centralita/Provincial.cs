using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

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

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat(" Costo de llamada: {0} | Franja Horaria: {1}", this.CostoLlamada, this.franjaHoraria);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
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


        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }
}
