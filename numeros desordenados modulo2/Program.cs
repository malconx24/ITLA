using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_desordenados_modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] numeros = new int[10];

                // Ingresar los números
                Console.WriteLine("Ingrese 10 números desordenados:");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"Número {i + 1}: ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Ordenar el arreglo
                Array.Sort(numeros);

                // Mostrar los números ordenados
                Console.WriteLine("\nNúmeros ordenados:");
                foreach (int num in numeros)
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine(); // Salto de línea al final
            }
        }
    }
    }

