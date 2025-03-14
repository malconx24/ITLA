using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serie_fibonacci.modulo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serie de Fibonacci hasta 50:");

            int a = 1, b = 1;

            Console.Write(a + " " + b + " ");

            while (true)
            {
                int siguiente = a + b;
                if (siguiente > 50) break;

                Console.Write(siguiente + " ");
                a = b;
                b = siguiente;
            }

            Console.WriteLine(); // Salto de línea al final
        }
    }

}