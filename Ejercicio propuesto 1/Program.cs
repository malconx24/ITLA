using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_propuesto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Ingrese su fecha de nacimiento (YYYY-MM-DD): ");
                string input = Console.ReadLine();

                if (DateTime.TryParse(input, out DateTime fechaNacimiento))
                {
                    Console.WriteLine($"Naciste un {fechaNacimiento.ToString("dddd")}.");
                }
                else
                {
                    Console.WriteLine("Fecha no válida. Asegúrate de ingresar el formato correcto (YYYY-MM-DD).");
                }
            }
        }
    }
}
