using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class CentralitaException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;
        
        public string NombreClase { get
            {
                return this.nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }

        public CentralitaException(string mensaje, string clase, string metodo) 
            : this(mensaje, clase, metodo, null)
        {

        }
        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
            : base (mensaje, innerException)
        {

        }
    }
}
