using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_63
{
    public partial class Form1 : Form
    {
        Temporizador temporizador;
        Thread primerHilo;
        public Form1()
        {
            this.temporizador = new Temporizador();
            InitializeComponent();
        }

        public void TemporizadorHandler()
        {
            this.label1.Text = DateTime.Now.ToString();
        }

        delegate void DelegadoSetHora();
        public void AsignarHora()
        {
            if (this.label1.InvokeRequired)
            {
                DelegadoSetHora auxDelegado = new DelegadoSetHora(AsignarHora);
                this.Invoke(auxDelegado);
            } 
            else
            {
                this.label1.Text = DateTime.Now.ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ThreadStart ts = new ThreadStart(ModificarHora);
            //this.primerHilo = new Thread(ts);
            //this.primerHilo.Start();
            //this.ModificarHora();

            temporizador.EventoTiempo += TemporizadorHandler;
            temporizador.Intervalo = 1000;
            temporizador.Activo = true;
        
        }

        public void ModificarHora()
        {

        }
    }
}
