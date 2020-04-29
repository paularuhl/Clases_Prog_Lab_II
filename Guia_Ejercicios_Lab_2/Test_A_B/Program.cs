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

            B b = new B();

            A a = b;

            a.F();

            Console.ReadKey();

            b.F();

            Console.ReadKey();

            a.G();

            Console.ReadKey();

            b.G();

            Console.ReadKey();
        }



        public class B : A

        {

            new public void F() { Console.WriteLine("B.F()"); }

            public override void G() { Console.WriteLine("B.G()"); }

        }



        public class A

        {

            public void F()

            {

                Console.WriteLine("A.F()");

            }

            public virtual void G()

            {

                Console.WriteLine("A.G()");

            }

        }




    }
}
