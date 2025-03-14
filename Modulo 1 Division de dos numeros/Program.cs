using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_1_Division_de_dos_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    Console.Write("Ingrese el primer número: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Ingrese el segundo número: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    }
                    else
                    {
                        double resultado = num1 / num2;
                        Console.WriteLine($"El resultado de la división es: {resultado}");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Ingrese valores numéricos válidos.");
                }
            }
        }
    }
    }

