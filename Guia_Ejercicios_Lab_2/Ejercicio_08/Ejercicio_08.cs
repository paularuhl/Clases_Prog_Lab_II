using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Ejercicio_08
    {
        static readonly string[] respuestas = { "SI", "NO" };
        static void Main(string[] args)
        {
            /*Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
            trabajadas en el mes de N empleados de una fábrica.

            Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
            valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
            multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
            descuentos.
            Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
            bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.*/
            Console.Title = "Ejercicio Nro 08";

            string nombreApellido;
            double antiguedad;
            double valorHora;
            double horasTrabajadas;
            const double plusAntiguedad = 150;
            const double porcentajeDescuentos = 0.13;
            bool dataOk = true;
            bool ingresarOtroEmpleado = true;
            double sueldoBruto;
            double sueldoNeto;
            double totalDescuentos;
            List<string> recibos = new List<string>();
            string respuesta;

            do
            {
                do
                {
                    if (!dataOk) Console.Write("El nombre solo puede estar compuesto de letras! ");
                    Console.Write("Ingrese nombre de empleado: ");
                    dataOk = ValidarStringAlfabetica(Console.ReadLine(), out nombreApellido);
                } while (!dataOk);

                do
                {
                    if (!dataOk) Console.Write("La antiguedad solo puede estar compuesta de numeros! ");
                    Console.Write("Ingrese antigüedad en años: ");
                    dataOk = double.TryParse(Console.ReadLine(), out antiguedad);
                } while (!dataOk);

                do
                {
                    if (!dataOk) Console.Write("El valor solo puede estar compuesto de numeros! ");
                    Console.Write("Ingrese el valor por hora : ");
                    dataOk = double.TryParse(Console.ReadLine(), out valorHora);
                } while (!dataOk);

                do
                {
                    if (!dataOk) Console.Write("El valor solo puede estar compuesto de numeros! ");
                    Console.Write("Ingrese las horas trabajadas: ");
                    dataOk = double.TryParse(Console.ReadLine(), out horasTrabajadas);
                } while (!dataOk);

                sueldoBruto = (valorHora * horasTrabajadas) + (antiguedad * plusAntiguedad);
                sueldoNeto = Math.Round(sueldoBruto * porcentajeDescuentos);
                totalDescuentos = sueldoBruto - sueldoNeto;

                string reciboSueldo = $"-Recibo de sueldo de {nombreApellido}\n-Antiguedad:         {antiguedad} año/s\n-Valor Hora:         ${valorHora}\n-Sueldo Bruto:       ${sueldoBruto}\n-Sueldo Neto:        ${sueldoNeto}";

                recibos.Add(reciboSueldo);
                do
                {
                    Console.WriteLine("Ingresar otro empleado? Si/No: ");
                    respuesta = Console.ReadLine().ToUpper();
                    dataOk = respuestas.Contains(respuesta);
                } while (!dataOk);

                ingresarOtroEmpleado = respuesta == respuestas[0];

            } while (ingresarOtroEmpleado);

            foreach(string recibo in recibos)
            {
                Console.WriteLine(recibo);
                Console.WriteLine("----------------------------------");
            }
            Console.ReadKey();
        }

        static bool ValidarStringAlfabetica(string aux, out string validatedString)
        {
            validatedString = aux;
            return Regex.IsMatch(aux, @"\A[\p{L}\s]+\Z")/*aux.Any(x => !Regex.IsMatch(x.ToString(), @"^[a-zA-Z ]+$"))*/;
        }


    }
}
