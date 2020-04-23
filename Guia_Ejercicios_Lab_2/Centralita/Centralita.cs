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

        public float GananciasPorLocal { get; }
        public float GananciasPorProvincial { get; }
        public float GananciasPorTotal { get; }
        public List<Llamada> Llamadas {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            return 0;
        }

        public Centralita()
        {

        }

        public Centralita(string nombreEmpresa)
        {
            this.razonSocial = nombreEmpresa;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }
        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort((a, b) => Llamada.OrdenarPorDuracion(a, b));
        }
    }
}
