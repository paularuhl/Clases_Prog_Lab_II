using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21
{
    class Ejercicio_21
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
            Hola a = new Holis();
            Holis b = (Holis)new Hola();

        }



    }

    public class Hola
    {

    }

    public class Holis : Hola { 
    }

}
