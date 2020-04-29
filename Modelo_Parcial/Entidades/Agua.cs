using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Agua : Botella
    {
        const int MEDIDA = 400;
        public Agua(int capacidadML, string marca, int contenidoML)
            : base(marca, capacidadML, contenidoML)
        {

        }

        protected new string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} MEDIDA: {1}ml", base.ToString(), MEDIDA);
            return sb.ToString();
        }

        public override int ServirMedida()
        {
            return this.ServirMedida(MEDIDA);
        }
        public int ServirMedida(int medida)
        {
            int servido;
            if (medida <= base.Contenido)
            {
                servido = medida;
                base.Contenido -= medida;
            }
            else
            {
                servido = base.Contenido;
                base.Contenido -= base.Contenido;
            }
            return servido;
        }

    }
}
