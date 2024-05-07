using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iekavetais_rekursija
{
    internal class Program
        {
        static int Progressija(int n, int diference, int starts)
            {
                if (n == 1)
                {
                    return starts;
                }
                else
                {
                    return Progressija(n - 1, diference, starts) + diference;
                }
            }

            static void Main(string[] args)
            {
                Console.Write("Cik elementus izvadīt: ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Progresijas solis: ");
                int diference = int.Parse(Console.ReadLine());

                Console.Write("Progresijas sākums: ");
                int starts = int.Parse(Console.ReadLine());

                // Izvada aritmētisko progresiju
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(Progressija(i, diference, starts) + " ");
                }
            }
        }
    }
