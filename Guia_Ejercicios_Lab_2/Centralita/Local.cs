using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return this.costo * base.Duracion;
        }

        public Local(Llamada llamada, float costo) 
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        public Local(string origen, float duracion, string destino, float costo) 
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat(" Costo de llamada: {0}", CostoLlamada);

            return sb.ToString();
        }
    }
}
