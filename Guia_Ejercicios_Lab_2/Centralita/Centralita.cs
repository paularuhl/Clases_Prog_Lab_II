using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;
            foreach(Llamada llamada in Llamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if(llamada is Local) ganancia += ((Local)llamada).CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial) ganancia += ((Provincial)llamada).CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (llamada is Local)
                            ganancia += ((Local)llamada).CostoLlamada;
                        else if (llamada is Provincial)
                            ganancia += ((Provincial)llamada).CostoLlamada;
                        break;
                }
            }
            return ganancia;
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Razón Social: {0}\n", this.razonSocial);
            sb.AppendFormat("Ganancia Total: {0}\n", this.GananciasPorTotal);
            sb.AppendFormat("Ganancia Local: {0}\n", this.GananciasPorLocal);
            sb.AppendFormat("Ganancia Provincial: {0}\n", this.GananciasPorProvincial);

            sb.AppendLine("Detalle de llamadas:");

            foreach(Llamada llamada in Llamadas)
            {
                if(llamada is Local) sb.AppendLine(((Local)llamada).Mostrar());
                if (llamada is Provincial) sb.AppendLine(((Provincial)llamada).Mostrar());

            }
            return sb.ToString();
        }
        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort((a, b) => Llamada.OrdenarPorDuracion(a, b));
        }
    }
}
