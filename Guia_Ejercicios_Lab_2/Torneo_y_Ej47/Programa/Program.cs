using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneo1 = new Torneo<EquipoFutbol>("EQUIPOS DE FUTBOL");
            Torneo<EquipoBasquet> torneo2 = new Torneo<EquipoBasquet>("EQUIPOS DE BASQUET");

            EquipoBasquet e1 = new EquipoBasquet("Basquet UNO",DateTime.Now.AddYears(-1));
            EquipoBasquet e2 = new EquipoBasquet("Basquet DOS", DateTime.Now.AddYears(-1).AddMonths(2).AddDays(3));
            EquipoBasquet e3 = new EquipoBasquet("Basquet TRES", DateTime.Now.AddYears(-1).AddMonths(-3));
            EquipoFutbol e4 = new EquipoFutbol("Futbol UNO", DateTime.Now.AddYears(-3).AddDays(3));
            EquipoFutbol e5 = new EquipoFutbol("Futbol DOS", DateTime.Now.AddYears(-4).AddMonths(5));
            EquipoFutbol e6 = new EquipoFutbol("Futbol TRES", DateTime.Now.AddYears(-3).AddMonths(2));

            torneo1 += e4;
            torneo1 += e5;
            torneo1 += e6;

            torneo2 += e1;
            torneo2 += e2;
            torneo2 += e3;

            Console.WriteLine(torneo1.JugarPartido);
            Console.WriteLine(torneo1.JugarPartido);
            Console.WriteLine(torneo1.JugarPartido);

            Console.WriteLine(torneo2.JugarPartido);
            Console.WriteLine(torneo2.JugarPartido);
            Console.WriteLine(torneo2.JugarPartido);

            Console.WriteLine(torneo1.Mostrar());
            Console.WriteLine(torneo2.Mostrar());

            Console.ReadKey();

        }
    }
}
