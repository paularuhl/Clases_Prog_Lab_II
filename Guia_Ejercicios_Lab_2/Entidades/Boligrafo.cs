using System;
using System.Text;

namespace Entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.SetTinta(tinta);
            this.color = color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool puedePintar = this.tinta > 0;
            StringBuilder db = new StringBuilder();

            while (this.tinta > 0 && gasto > 0)
            {
                db.Append("*");
                this.tinta--;
                gasto--;
            }
            dibujo = db.ToString();
            Console.ForegroundColor = this.GetColor();

            return puedePintar;
        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        private void SetTinta(short tinta)
        {
            this.tinta += tinta;
            if (this.tinta >= cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
            else if (this.tinta <= 0)
            {
                this.tinta = 0;
            }
        }
    }
}
