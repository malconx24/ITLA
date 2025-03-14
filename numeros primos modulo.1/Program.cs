using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_primos_modulo._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Ingrese un número: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(EsPrimo(numero) ? $"{numero} es primo." : $"{numero} no es primo.");
            }

             bool EsPrimo(int num)
            {
                if (num < 2) return false;
                if (num == 2 || num == 3) return true;
                if (num % 2 == 0 || num % 3 == 0) return false;

                for (int i = 5; i * i <= num; i += 6)
                {
                    if (num % i == 0 || num % (i + 2) == 0) return false;
                }
                return true;
            }
        }
    }
    }
