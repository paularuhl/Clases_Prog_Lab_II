using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal = -1;
        public string apellido;
        public int legajo;
        public string nombre;

        private Random generadorNotaFinal = new Random(Environment.TickCount);

        public void CalcularFinal()
        {
            if(this.nota1 > 3 && this.nota2 > 3)
            {
                notaFinal = generadorNotaFinal.Next(1,10);
            } 
        }

        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public string Mostrar()
        {
            string mensaje = $"Alumno: {this.apellido}, {this.nombre} Legajo n°: {this.legajo}\nNota 1: {this.nota1}\nNota 2: {this.nota2}.\n";
            mensaje = notaFinal == -1 ? $"{mensaje}Alumno desaprobado.\n" : $"{mensaje}Nota Final: {this.notaFinal}\n";
            return mensaje;
        }
    }
}
