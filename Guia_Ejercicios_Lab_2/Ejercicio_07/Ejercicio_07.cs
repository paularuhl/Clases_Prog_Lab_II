using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Ejercicio_07
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07";
            /*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
            calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
            con DateTime.Now).*/

            DateTime fechaNacimiento;
            int dia;
            int mes;
            int anio;
            bool esNumero = true;
            bool cumpleMedidas = true;
            string mensajeError = string.Empty;

            do
            {
                if(!esNumero)
                    Console.WriteLine("El año debe ser un numero positivo!");
                Console.Write("Ingrese su año de nacimiento: ");
                esNumero = int.TryParse(Console.ReadLine(), out anio);
                cumpleMedidas = anio > 0;
            } while (!esNumero && !cumpleMedidas);

            do
            {
                if(!cumpleMedidas) Console.WriteLine(mensajeError);
                Console.Write("Ingrese su mes de nacimiento: ");
                esNumero = int.TryParse(Console.ReadLine(), out mes);
                cumpleMedidas = mes > 1 && mes < 12;
                if (!cumpleMedidas) mensajeError = "Los meses existen desde enero (1) hasta diciembre (12)...";

            } while (!esNumero || !cumpleMedidas);

            do
            {
                if (!cumpleMedidas)
                    Console.WriteLine(mensajeError);
                Console.Write("Ingrese su dia de nacimiento: ");
                esNumero = int.TryParse(Console.ReadLine(), out dia);

                if (esNumero)
                {
                    bool esBisiesto = EsBisiesto(anio);
                    switch (mes)
                    {
                        case 2:
                            if ((esBisiesto && dia > 29) || (!esBisiesto && dia > 28))
                            {
                                cumpleMedidas = false;
                                mensajeError = $"Febrero es un mes especial... ";
                                mensajeError = esBisiesto ? mensajeError + $"y en el año que ingresaste ({anio}) no tiene mas de 29 dias!"
                                    : mensajeError + $"y en el año que ingresaste ({anio}) no tiene mas de 28 dias!";
                            }
                            else cumpleMedidas = true;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            if (dia > 30)
                            {
                                cumpleMedidas = false;
                                mensajeError = $"El mes {mes} no tiene mas de 30 días!";
                            }
                            else cumpleMedidas = true;
                            break;
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            if (dia > 31)
                            {
                                cumpleMedidas = false;
                                mensajeError = $"El mes {mes} no tiene mas de 31 días!";
                            }
                            else cumpleMedidas = true;
                            break;
                        default:
                            break;
                    }
                }

            } while (!esNumero || !cumpleMedidas);

            Console.WriteLine("Muy bien! Calculando...");
            fechaNacimiento = new DateTime(anio, mes, dia);

            int resultado = DateTime.Now.Subtract(fechaNacimiento).Days;

            Console.WriteLine($"Desde que naciste ({fechaNacimiento.ToShortDateString()}) hasta el día de hoy ({DateTime.Now.ToShortDateString()}) pasaron {resultado} días!");

            Console.ReadKey();
        }

        public static bool EsBisiesto(int anio)
        {
            if (anio % 100 == 0)
            {
                if (anio % 400 == 0)
                    return true;
            }
            else if (anio % 4 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
