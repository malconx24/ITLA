using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.propuesto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Pedir al usuario que ingrese su nombre
                Console.Write("Por favor, ingresa tu nombre: ");
                string nombre = Console.ReadLine();

                // Obtener la inicial del nombre
                char inicial = char.ToUpper(nombre[0]);

                // Mostrar la inicial
                Console.WriteLine($"La inicial de tu nombre es: {inicial}");
            }
        }
    }
    }

