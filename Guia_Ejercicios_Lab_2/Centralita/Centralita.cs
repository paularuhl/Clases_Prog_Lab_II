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
                        if(llamada is Local) ganancia += llamada.CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial) ganancia += llamada.CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Todas:
                        ganancia += llamada.CostoLlamada;
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

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Razón Social: {0}\n", this.razonSocial);
            sb.AppendFormat("Ganancia Total: {0}\n", this.GananciasPorTotal);
            sb.AppendFormat("Ganancia Local: {0}\n", this.GananciasPorLocal);
            sb.AppendFormat("Ganancia Provincial: {0}\n", this.GananciasPorProvincial);

            sb.AppendLine("Detalle de llamadas:");

            foreach(Llamada llamada in Llamadas)
            {
                sb.AppendLine(llamada.ToString());
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort((a, b) => Llamada.OrdenarPorDuracion(a, b));
        }


        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach(Llamada l in c.Llamadas)
            {
                if(l == llamada) return true;
            }
            return false;

        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada llamada)
        {
            if (c != llamada)
            {
                c.Llamadas.Add(llamada);
            }
            return c;
        }


    }
}
