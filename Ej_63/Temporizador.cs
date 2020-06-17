using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ej_63
{
    public sealed class Temporizador
    {
        private Thread hilo;
        private int intervalo;

        public delegate void encargadoTiempo();

        public event encargadoTiempo EventoTiempo;

        public bool Activo 
        { 
            get 
            { 
                return this.hilo != null && this.hilo.IsAlive;
            } 
            set 
            { 
                if(value && !this.Activo)
                {
                    this.hilo = new Thread(Corriendo);
                    this.hilo.Start();
                }
                else if (!value && this.Activo)
                {
                    this.hilo.Abort();
                }
                
            } 
        }
        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }

        private void Corriendo()
        {

            while (true)
            {
                Thread.Sleep(Intervalo);
                if (this.EventoTiempo != null)
                {
                    this.EventoTiempo.Invoke();
                } 
            } 
        
        }

    }
}
