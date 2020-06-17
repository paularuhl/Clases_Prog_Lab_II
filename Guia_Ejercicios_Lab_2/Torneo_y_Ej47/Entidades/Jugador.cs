using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }
        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }
        public float PromedioGoles
        {
            get
            { 
            return this.totalGoles / this.partidosJugados;
            }
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }


        private Jugador() { }

        public Jugador(int dni, string nombre) : this()
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}, DNI: {1}, ", this.Nombre, this.Dni);
            sb.AppendFormat("Total Goles: {0}, Partidos Jugados: {1}, ", this.TotalGoles, this.PartidosJugados);
            sb.AppendFormat("Promedio Goles: {0} ", this.PromedioGoles);
            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
