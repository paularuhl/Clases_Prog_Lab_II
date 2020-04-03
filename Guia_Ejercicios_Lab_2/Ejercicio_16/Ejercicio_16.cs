using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Ejercicio_16
    {
        static void Main(string[] args)
        {
            Alumno alumnoUno = new Alumno();
            Alumno alumnoDos = new Alumno();
            Alumno alumnoTres = new Alumno();

            alumnoUno.nombre = "Paula";
            alumnoUno.apellido = "Ruhl";
            alumnoUno.legajo = 111;

            alumnoDos.nombre = "Luke";
            alumnoDos.apellido = "Skywalker";
            alumnoDos.legajo = 112;

            alumnoTres.nombre = "Leia";
            alumnoTres.apellido = "Organa";
            alumnoTres.legajo = 113;

            alumnoUno.Estudiar(7, 4);
            alumnoDos.Estudiar(4, 10);
            alumnoTres.Estudiar(3, 2);


            alumnoUno.CalcularFinal();
            alumnoDos.CalcularFinal();
            alumnoTres.CalcularFinal();
            Console.WriteLine(alumnoUno.Mostrar() + alumnoDos.Mostrar() + alumnoTres.Mostrar());
            Console.ReadKey();
        }
    }
}
