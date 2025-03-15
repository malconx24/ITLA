using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                MostrarCalendario(DateTime.Now.Year, DateTime.Now.Month);
            }

             void MostrarCalendario(int year, int month)
            {
                DateTime primerDia = new DateTime(year, month, 1);
                int diasEnMes = DateTime.DaysInMonth(year, month);
                int diaSemana = (int)primerDia.DayOfWeek;

                string[] diasSemana = { "Do", "Lu", "Ma", "Mi", "Ju", "Vi", "Sa" };

                Console.WriteLine($"Calendario de {primerDia.ToString("MMMM yyyy")}\n");
                foreach (string dia in diasSemana)
                {
                    Console.Write(dia + " ");
                }
                Console.WriteLine();

                for (int i = 0; i < diaSemana; i++)
                {
                    Console.Write("   ");
                }

                for (int dia = 1; dia <= diasEnMes; dia++)
                {
                    Console.Write(dia.ToString("D2") + " ");
                    if ((dia + diaSemana) % 7 == 0)
                    {
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
        }

    }
}

