using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;
        public Cerveza(int capacidadML, string marca, int contenidoML) : this(capacidadML, marca, Tipo.Vidrio, contenidoML)
        {

        }
        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML) 
            : base(marca, capacidadML, contenidoML)
        {
            this.tipo = tipo;
        }

        public override int ServirMedida()
        {
            int servido;
            if (MEDIDA <= this.Contenido)
            {
                servido = MEDIDA;
                base.Contenido -= (int)(MEDIDA * 0.8);
            }
            else
            {
                servido = this.Contenido;
                base.Contenido -= (int)(base.Contenido * 0.8);
            }
            return servido;
        }

        protected new string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Tipo de botella: {1} | Medida: {2}ml", base.ToString(), tipo, MEDIDA);
            return sb.ToString();
        }
    }
}
