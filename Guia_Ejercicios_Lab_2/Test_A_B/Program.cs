using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_A_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<a> personas = new Stack<a>();
            personas.Push(new c());
            personas.Push(new a());
            personas.Push(new b());
            foreach(a letra in personas)
            {
                Console.WriteLine(letra.poop());
            }
            Console.ReadKey();
        }




      



    }

    public class a
    {
        public virtual string poop()
        {
            return "aaa";
        }
    }
    public class b : a
    {
        public override string poop()
        {
            return "eeeee";
        }
    }
    public class c : a
    {
        public override string poop()
        {
            return "iii";
        }
    }
}
